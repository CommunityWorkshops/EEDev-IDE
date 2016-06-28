using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using EEDev_IDE.Controls;

namespace EEDev_IDE.Forms.Dialog
{
    public partial class FrmNewProject : Form
    {
        public string SelectedProjectType { get; private set; }
        public string SelectedProjectVariation { get; private set; }

        public FrmNewProject()
        {
            InitializeComponent();
            // Load project types
            LoadProjectTypes();
            LoadProjectVariants();
        }

        private void LoadProjectVariants()
        {
            // Load the variants project types for the first project type displayed
            LoadVariants((NewProjectChoice)flpProjectTypes.Controls[0]);            
        }

        private void LoadVariants(NewProjectChoice control)
        {
            var doc = new XmlDocument();
            doc.Load("Data\\AvailableProjects.xml");

            if (doc.DocumentElement == null) return;
            foreach (var node in doc.DocumentElement.Cast<XmlNode>().Where(node => node.Name.ToLower() == "projects"))
            {
                LoadProjectVariants(node, control.Tag.ToString());
            }

            doc = null;
        }

        private void LoadProjectVariants(XmlNode node, string type)
        {
            foreach (XmlNode element in node)
            {
                if (element.Attributes?[0].Value == type)
                {
                    foreach (XmlNode childNode in element.ChildNodes)
                    {
                        if (childNode.Attributes != null) LoadProjectVariation(childNode.Attributes[0].Value,type);
                    }
                }
            }            
        }

        private void LoadProjectVariation(string variationType, string projectType)
        {
            var projectVariationPath = "Templates\\Projects\\" + projectType + "\\Types\\" + variationType;
            if (Directory.Exists(projectVariationPath))
            {

                var npc = new NewProjectChoice(GetProjectTypeVariationImage(projectType, variationType),
                          variationType.Normalize())
                {
                    Tag = variationType
                };

                npc.NewProjectTypeSelectedEvent += Npc_NewProjectTypeSelectedEvent;
                flpProjectTypeVariations.Controls.Add(npc);

            }
        }

        private void Npc_NewProjectTypeSelectedEvent(string projectName)
        {
            SelectedProjectVariation = projectName;
            lblSelectedProjectType.Text = SelectedProjectType + " " + SelectedProjectVariation;
        }

       
        private Image GetProjectTypeVariationImage(string projectType, string variationType)
        {
            return Image.FromFile("Templates\\Projects\\" + projectType + "\\Types\\" + variationType + "\\Images\\ProjectImage.jpg");
        }

        private void LoadProjectTypes()
        {
            var doc = new XmlDocument();
            doc.Load("Data\\AvailableProjects.xml");

            if (doc.DocumentElement == null) return;
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Name.ToLower() == "information") LoadInformation(node);
                if (node.Name.ToLower() == "projects") LoadProjects(node);
            }

            doc = null;
        }

        private void LoadProjects(XmlNode node)
        {
            foreach (var element in node.Cast<XmlElement>().Where(element => element.HasAttributes))
            {
                LoadProjectType(element.GetAttribute("name"));
            }
        }

        private void LoadProjectType(string projectType)
        {
            // The Project Type gives to the path of the project
            // Templates\\Projects\\<projectType>

            var projectPath = "Templates\\Projects\\" + projectType;

            // Check that it exists
            if (Directory.Exists(projectPath))
            {
                // Show Project Selector Control
                var npc = new NewProjectChoice(GetProjectTypeImage(projectType), projectType.Normalize())
                {
                    Tag = projectType                    
                };

                npc.NewProjectTypeSelectedEvent += Npc_NewProjectTypeSelectedEvent1;
                npc.Selected();
                flpProjectTypes.Controls.Add(npc);

                // Display Project Variant Selector Control
            }
            else
            {
                //TODO: Show Missing Project - Do they want to remove it?
            }
        }

        private void Npc_NewProjectTypeSelectedEvent1(string projectName)
        {
            SelectedProjectType = projectName;
            lblSelectedProjectType.Text = SelectedProjectType + " " + SelectedProjectVariation;
        }

        private static Image GetProjectTypeImage(string projectType)
        {
            //TODO: Check that image exists - if not return default missing project image
            return Image.FromFile("Templates\\Projects\\" + projectType + "\\Image\\ProjectImage.jpg");
        }

        private void LoadInformation(XmlNode node)
        {
            foreach (var childNode in from XmlElement element in node
                                      where element.Name.ToLower() == "information"
                                      from XmlNode childNode in element
                                      select childNode)
            {
                if (childNode.Name.ToLower() == "projects") lblTotalProjectTypes.Text = childNode.InnerText;
                if (childNode.Name.ToLower() == "variations") lblTotalVariants.Text = childNode.InnerText;
            }
        }
    }
}
