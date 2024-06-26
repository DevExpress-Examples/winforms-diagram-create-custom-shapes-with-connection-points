<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585324/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T324404)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DiagramResources.xaml](./CS/DxSample/DiagramResources.xaml) (VB: [DiagramResources.xaml](./VB/DxSample/DiagramResources.xaml))
* [Form1.cs](./CS/DxSample/Form1.cs) (VB: [Form1.vb](./VB/DxSample/Form1.vb))
<!-- default file list end -->
# DiagramControl - How to create custom shapes with connection points


The Diagram control supports a special language for defining shapes. The main element that contains shape description is <em>ShapeTemplate</em>. This element describes a shape contour and may contain several segments

* <em>Start</em>. Specifies the start point
* <em>Line</em>. Defines a line with start and end points
* <em>Arc</em>. Defines an arc with start and end points<br><br>To specify connection points, use the <em>ShapeTemplate.ConnectionPoints</em> property.<br>Shapes may contain parameters. Parameters may be used to dynamically calculate an end point, row height, and other properties. To specify parameters, use the <em>ShapeTemplate.Parameters</em> property.<br>To register custom shapes, create a stencil with the <em>DiagramStencil.Create</em> method and pass it to the <em>DiagramToolboxRegistrator.RegisterStencil</em> method.<br><br><br><strong>Note:</strong> <em>Starting with version 16.1, it is recommended to use XML to describe custom shapes. If you prefer to use XAML instead, take a look at the following example: <a href="https://www.devexpress.com/Support/Center/p/T381372">T381372 - DiagramControl - How to create custom shapes with connection points using XAML markup</a>.</em>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-diagram-create-custom-shapes-with-connection-points&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-diagram-create-custom-shapes-with-connection-points&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
