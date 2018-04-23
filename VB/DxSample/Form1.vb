Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core

Namespace DxSample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            RegisterCustomShapes()
            Me.diagramControl1.InitializeRibbon(Me.ribbonControl1)
        End Sub

        Private Shared Sub RegisterCustomShapes()
            Dim dict = New System.Windows.ResourceDictionary()
            dict.Source = New Uri("DiagramResources.xaml", UriKind.RelativeOrAbsolute)
            DiagramToolboxRegistrator.RegisterShapes("CustomShapes", Function() "Custom Shapes", dict, Function(id) id)
        End Sub
    End Class
End Namespace
