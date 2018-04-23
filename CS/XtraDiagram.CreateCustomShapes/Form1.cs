using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Shapes;
using System.Windows;
using System.IO;
using System.Reflection;

namespace XtraDiagram.CreateCustomShapes {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
            RegisterCustomShapes();
            this.diagramControl1.SelectedStencils = new StencilCollection(new string[] { "CustomShapes" });
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.diagramControl1.InitializeRibbon(this.ribbonControl1);
        }

        void RegisterCustomShapes() {
            using(var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("XtraDiagram.CreateCustomShapes.CustomShapes.xml")) {
                var stencil = DiagramStencil.Create("CustomShapes", "Custom Shapes", stream, shapeName => shapeName);
                DiagramToolboxRegistrator.RegisterStencil(stencil);
            }
        }
    }
    
}
