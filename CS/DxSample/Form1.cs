using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Diagram.Core;

namespace DxSample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RegisterCustomShapes();
            this.diagramControl1.InitializeRibbon(this.ribbonControl1);
        }

        static void RegisterCustomShapes() {
            var dict = new System.Windows.ResourceDictionary();
            dict.Source = new Uri("DiagramResources.xaml", UriKind.RelativeOrAbsolute);
            DiagramToolboxRegistrator.RegisterShapes("CustomShapes", () => "Custom Shapes", dict, id => id);
        }
    }
}
