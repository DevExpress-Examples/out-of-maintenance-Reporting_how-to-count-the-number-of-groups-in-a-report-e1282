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


