Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Shapes
Imports System.Windows
Imports System.IO
Imports System.Reflection

Namespace XtraDiagram.CreateCustomShapes
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            RegisterCustomShapes()
            Me.diagramControl1.SelectedStencils = New StencilCollection(New String() {"CustomShapes"})
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.diagramControl1.InitializeRibbon(Me.ribbonControl1)
        End Sub

        Private Sub RegisterCustomShapes()
            Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("CustomShapes.xml")
                Dim stencil = DiagramStencil.Create("CustomShapes", "Custom Shapes", stream, Function(shapeName) shapeName)
                DiagramToolboxRegistrator.RegisterStencil(stencil)
            End Using
        End Sub
    End Class

End Namespace
