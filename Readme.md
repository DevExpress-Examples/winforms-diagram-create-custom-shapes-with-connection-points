<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585324/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T324404)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Diagram Control for WinForms - Create Custom Shapes with Connection Points

This example demonstrates how to define custom shapes for the [DiagramControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl) in XML.

![image](https://user-images.githubusercontent.com/65009440/187895616-f50a9c14-832a-4420-9b13-961c8b3df3fa.png)

The **ShapeTemplate** class describes a [diagram shape](https://docs.devexpress.com/WindowsForms/116882/controls-and-libraries/diagrams/diagram-items/shapes) and contains the following segments:

* [Start](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Start) - Specifies the start point of the geometry and includes customization properties. A shape can consist of multiple geometries.
* [Line](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Line) - Defines a line with start and end points.
* [Arc](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Arc) - Defines an arc with the size and direction.
* **ShapePoint** - Defines a [connection point](https://docs.devexpress.com/WindowsForms/116884/controls-and-libraries/diagrams/diagram-items/connectors). To specify connection points, use the **ShapeTemplate.ConnectionPoints** property.
* [Parameter](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Parameter) - Defines a parameter that allows users to transform the shape. To specify parameters, use the **ShapeTemplate.Parameters** property.

Refer to the following help topic for more information about supported segments: [Creating Shapes and Containers Using Shape Templates](https://docs.devexpress.com/WindowsForms/17764/controls-and-libraries/diagrams/diagram-items/creating-shapes-and-containers-using-shape-templates).

To register custom shapes, create a stencil with the [DiagramStencil.Create](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.DiagramStencil.Create.overloads) method and pass it to the [DiagramToolboxRegistrator.RegisterStencil](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.DiagramToolboxRegistrator.RegisterStencil(DevExpress.Diagram.Core.DiagramStencil)) method.

To create a shape programmatically, get an instance of your custom stencil, call the [DiagramStencil.GetShape](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.DiagramStencil.GetShape(System.String)) method to access the [ShapeDescription](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.ShapeDescription) object, and assign it to the [DiagramShape.Shape](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramShape.Shape) property:

```cs
new DiagramShape() { Shape = customStencil.GetShape("Shape1")}
```

Starting with **v16.1**, we recommend to use XML to describe custom shapes. If you prefer to use XAML instead, take a look at the following example: [Diagram Control for WinForms - Create Custom Shapes with Connection Points in XAML](https://github.com/DevExpress-Examples/diagramcontrol-how-to-create-custom-shapes-with-connection-points-using-xaml-markup-t381372).

## Files to Look At

* [CustomShapes.xml](./CS/XtraDiagram.CreateCustomShapes/CustomShapes.xml)
* [Form1.cs](./CS/XtraDiagram.CreateCustomShapes/Form1.cs) (VB: [Form1.vb](./VB/XtraDiagram.CreateCustomShapes/Form1.vb))

## Documentation

* [Creating Shapes and Containers Using Shape Templates](https://docs.devexpress.com/WindowsForms/17764/controls-and-libraries/diagrams/diagram-items/creating-shapes-and-containers-using-shape-templates)
* [Diagrams](https://docs.devexpress.com/WindowsForms/114833/controls-and-libraries/diagrams)
* [Shapes](https://docs.devexpress.com/WindowsForms/116882/controls-and-libraries/diagrams/diagram-items/shapes)

## More Examples

* [Diagram Control for WinForms - Create Custom Shapes with Connection Points in XAML](https://github.com/DevExpress-Examples/diagramcontrol-how-to-create-custom-shapes-with-connection-points-using-xaml-markup-t381372)
* [How to create a DiagramShape descendant and serialize its properties](https://github.com/DevExpress-Examples/how-to-create-a-diagramshape-descendant-and-serialize-its-properties-t361265)
* [How to create custom diagram containers and register them in the toolbox and ribbon gallery](https://github.com/DevExpress-Examples/how-to-create-custom-diagram-containers-and-register-them-in-the-toolbox-and-ribbon-gallery-t466447)
