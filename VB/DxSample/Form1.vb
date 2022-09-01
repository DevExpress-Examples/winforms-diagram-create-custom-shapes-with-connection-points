Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Diagram.Core

Namespace DxSample

    Public Partial Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Call RegisterCustomShapes()
            diagramControl1.InitializeRibbon(ribbonControl1)
        End Sub

        Private Shared Sub RegisterCustomShapes()
            Dim dict = New System.Windows.ResourceDictionary()
            dict.Source = New Uri("DiagramResources.xaml", UriKind.RelativeOrAbsolute)
            DiagramToolboxRegistrator.RegisterShapes("CustomShapes", Function() "Custom Shapes", dict, Function(id) id)
        End Sub
    End Class
End Namespace
