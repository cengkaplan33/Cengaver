EPPlus 4.0.0 Beta

Visit epplus.codeplex.com for the latest information

EPPlus-Create Advanced Excel spreadsheet.

This is a beta release. Please test and give us some feedback

New features

Replaced Packaging API with DotNetZip
* This will remove any problems with Isolated Storage and enable multi threading 


New Cell store
* Less memory consumtion
* Insert columns (not on the range level)
* Faster row inserts,

Formula Parser
* Calculates all formulas in a workbook, a worksheet or in a specified range
* 100+ functions implemented
* Access via Calculate methods on Workbook, Worksheet and Range objects.
* Add custom/missing Excel functions via Workbook.FormulaParserManager.
* Samples added to the EPPlusSamples project.

The formula parser does not support Array Formulas
* Intersect operator (Space)
* References to external workbooks
* And probably a whole lot of other stuff as well :)

Perfomance
*Of course the performance of the formula parser is nowhere near Excels.Our focus has been functionality.

Agile Encryption (Office 2012-)
* Support for newer type of encryption.

Minor new features
* Chart worksheets
* New Chart Types Bubblecharts
* Radar Charts
* Area Charts
* And lots of bugfixes...

