<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1321)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CheckCompatibility/Form1.cs) (VB: [Form1.vb](./VB/CheckCompatibility/Form1.vb))
* [Program.cs](./CS/CheckCompatibility/Program.cs) (VB: [Program.vb](./VB/CheckCompatibility/Program.vb))
<!-- default file list end -->
# How to check whether the series with the different view types are compatible


<p>This example illustrate how to check compatibility of the series with the different view types at runtime. Basically, types of the series to be combined should use the same Diagram<br />
type. So, to check whether series types are compatible, you can simply compare their Diagram types. To accomplish this task, create a new ChartControl instance when the series of the desired type is created, and then compare whether it has the same diagram type as an existing one.</p>

<br/>


