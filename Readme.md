<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599116/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1282)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GroupsCount/Form1.cs) (VB: [Form1.vb](./VB/GroupsCount/Form1.vb))
<!-- default file list end -->
# How to count the number of groups in a report


<p>This example demonstrates how to calculate a number of groups in a report at design time</p><p>For this, drop an XRLabel onto the ReportFooter, bind it to the data field being the grouping criteria for the GroupHeader band, and set its Summary.Running property to Report and the Summary.Func property to DCount. This function will filter out only unique, distinct records from the defined data column.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1650">How to group data</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1290">How to group (sort) a report by days of week</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E787">How to implement custom grouping (group by Year and Month)</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E810">How to insert page numbers for groups</a>.</p>

<br/>


