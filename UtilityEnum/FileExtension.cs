﻿using System.ComponentModel;

namespace UtilityEnum
{
    namespace FileExtension
    {
        public enum General
        {
            None,
            [Description("ACE Archiver compression file.")] ace = 1,
            [Description("Audio Interchange File used with SGI and Macintosh applications.")] aif,
            [Description("Animated cursors used in Microsoft Windows.")] ani,
            [Description("Application Program Interface.")] api,
            [Description("Clipart.")] art,
            [Description("ASCII text file.")] asc,
            [Description("Assembler code.")] asm,
            [Description("Microsoft Active Server Page.")] asp,
            [Description("Audio / Video Interleaved used for Windows based movies.")] avi,
            [Description("Backup Files.")] bak,
            [Description("BASIC programming language sourcecode.")] bas,
            [Description("MS - DOS batch file.")] bat,
            [Description("Briefcase document used in Windows.")] bfc,
            [Description("Binary File.")] bin,
            [Description("Bitmap format.")] bmp,
            [Description("Backup Disk for Quicken by Intuit.")] bud,
            [Description("Bzip2 - compressed files.")] bz2,
            [Description("C source file.")] c,
            [Description("Security Catalog file.")] cat,
            [Description("Cobol code.")] cbl,
            [Description("Computer Based Training.")] cbt,
            [Description("Compact Disc Audio Track.")] cda,
            [Description("Corel Draw Template file.")] cdt,
            [Description("ColdFusion Markup Language.")] cfml,
            [Description("Common Gateway Interface.Web based programs and scripts.")] cgi,
            [Description("Compiled HTML Help files used by Windows.")] chm,
            [Description("Javascript Class file.")] @class,
            [Description("Windows Clipboard file.")] clp,
            [Description("Dos Command File.")] cmd,
            [Description("Command File.")] com,
            [Description("Control panel ite.")] cpl,
            [Description("C++ programming language source code.")] cp,
            [Description("Cascading Style Sheet.Creates a common style reference for a set of web pages.")] css,
            [Description("Comma Separated Values format.")] csv,
            [Description("Corel Metafile.")] cmf,
            [Description("Cursor in Microsoft Windows.")] cur,
            [Description("Registry Backup file for Windows registry.")] dao,
            [Description("Data file.")] dat,
            [Description("Compressed Archive by Macintosh DiskDoubler.")] dd,
            [Description("Debian packages.")] deb,
            [Description("Device Driver.")] dev,
            [Description("Dictionary file.")] dic,
            [Description("Macromedia Director file.")] dir,
            [Description("Dynamic Linked Library. Microsoft application file.")] dll,
            [Description("Document format for Word Perfect and Microsoft Word.")] doc,
            [Description("Microsoft Word Template.")] dot,
            [Description("Device Driver.")] drv,
            [Description("TWAIN Data source file.")] ds,
            [Description("Dial-up networking configuration file.")] dun,
            [Description("Autocad drawing.")] dwg,
            [Description("Autocad drawing exchange format file.")] dxf,
            [Description("Enhanced Windows Metafile.")] emf,
            [Description("Microsoft Outlook e-mail file.")] eml,
            [Description("Encapsulated PostScript supported by most graphics programs.")] eps,
            [Description("Adobe PostScript Level II Encapsulated Postscript.")] eps2,
            [Description("DOS based executable file which is also known as a program.")] exe,
            [Description("Microsoft Fast Find file.")] ffl,
            [Description("Microsoft Fast Find file.")] ffo,
            [Description("Macromedia Flash movie format.")] fla,
            [Description("Font file.")] fnt,
            [Description("Graphics Interchange Format that supports animation. Created by CompuServe and used primarily for web use.")] gif,
            [Description("Windows global index. Contains the index information used by Help in Windows.")] gid,
            [Description("Microsoft Program Manager Group.")] grp,
            [Description("Unix compressed file.")] gz,
            [Description("Macintosh binary hex(binhex) file.")] hex,
            [Description("Standard help file.")] hlp,
            [Description("HyperTerminal files.")] ht,
            [Description("Macintosh binary hex(binhex) file.")] hqx,
            [Description("Hyper Text Markup. This markup language is used for web design.")] htm,
            [Description("Hyper Text Markup Language. This markup language is used for web design.")] html,
            [Description("Icon Library File.")] icl,
            [Description("Image Color Matching profile.")] icm,
            [Description("Microsoft icon image.")] ico,
            [Description("Information file used in Windows.")] inf,
            [Description("Initialization file used in Windows.")] ini,
            [Description("Java Archive. A compressed java file format.")] jar,
            [Description("Compression scheme supported by most graphics programs and used predominantly for web use.")] jpeg,
            [Description("More common extension for JPEG described above.")] jpg,
            [Description("JavaScript File - A text file containing JavaScript programming code.")] js,
            [Description("Microsoft Excel mailing labels.")] lab,
            [Description("eBooks in Microsoft Reader format.")] lit,
            [Description("Windows 9x shortcut file.")] lnk,
            [Description("Application log file.")] log,
            [Description("Autocad(visual) lisp program.")] lsp,
            [Description("Microsoft Access Query.")] maq,
            [Description("Microsoft Access Report.")] mar,
            [Description("Microsoft Access DataBase File.")] mdb,
            [Description("Rose model file. Opens with Visual Modeler or Rational Rose.")] mdl,
            [Description("MIDI music file.")] mid,
            [Description("Microsoft Windows 9.x kernel module.")] mod,
            [Description("Quicktime movie.")] mov,
            [Description("MPEG Audio Layer 3.")] mp3,
            [Description("Animation file format.")] mpeg,
            [Description("Microsoft Project File.")] mpp,
            [Description("Microsoft Outlook message file.")] msg,
            [Description("Netware command File.")] ncf,
            [Description("Netware loadable Module.")] nlm,
            [Description("Object file")] o,
            [Description("ActiveX Control: A component of the Windows environment. used by linkers.")] ocx,
            [Description("Ogg Vorbis digitally encoded music file.")] ogg,
            [Description("Microsoft Exchange/Outlook offline file.")] ost,
            [Description("WAD file that contains information about levels")] pak,
            [Description("Printer Control Language file. PCL is a Page Description Language developed by HP. Settings maps etc. for Quake and Doom")] pcl,
            [Description("Macintosh drawing format.")] pct,
            [Description("Portable Document File by Adobe.")] pdf,
            [Description("Port driver for windows 95. It is actually a virtual device driver (vxd).")] pdr,
            [Description("Web page that contains a PHP script.")] php,
            [Description("Web page that contains a PHP script.")] phtml,
            [Description("Program Information File")] pif,
            [Description("Perl source code file.")] pl,
            [Description("Perl Module.")] pm,
            [Description("Portable Network Graphic file.")] png,
            [Description("System Policy file for Windows NT.")] pol,
            [Description("Microsoft PowerPoint design template.")] pot,
            [Description("Microsoft PowerPoint slide show.")] pps,
            [Description("Microsoft PowerPoint presentation(default extension).")] ppt,
            [Description("A print file created as the result of printing to file.")] prn,
            [Description("PostScript file.")] ps,
            [Description("Native Adobe Photoshop format.")] psd,
            [Description("Paint Shop Pro image.")] psp,
            [Description("Personal Folder File for Microsoft Outlook.")] pst,
            [Description("Microsoft Publisher document.")] pub,
            [Description("Quicken Import file.")] qif,
            [Description("RealAudio Metafile.")] ram,
            [Description("RAR compressed archive created by Eugene Roshall.")] rar,
            [Description("Raw File Format.")] raw,
            [Description("Raster Document Object. Proprietary file type used on Xerox")] rdo,
            [Description("Registry file that contains registry settings.")] reg,
            [Description("RealAudio video file.")] rm,
            [Description("RedHat Package Manager.")] rpm,
            [Description("Standard resource file.")] rsc,
            [Description("Rich Text Format.")] rtf,
            [Description("Screen Saver file.")] scr,
            [Description("Self-extracting archive for Macintosh Stuffit files.")] sea,
            [Description("Standard Generalized Markup Language.")] sgml,
            [Description("Unix shell script.")] sh,
            [Description("HTML file that supports Server Side Includes(SSI).")] shtml,
            [Description("Compressed Macintosh Stuffit files.")] sit,
            [Description("SEGA mega drive ROM file.")] smd,
            [Description("Adobe scalable vector graphics file.")] svg,
            [Description("Shockwave Flash file by Macromedia.")] swf,
            [Description("DOS swap file.")] swp,
            [Description("Windows system file used for hardware configuration or drivers.")] sys,
            [Description("Unix Tape Archive.")] tar,
            [Description("Targa bitmap.")] tga,
            [Description("Tagged Image File Format.")] tiff,
            [Description("Windows temporary file.")] tmp,
            [Description("True Type font.")] ttf,
            [Description("Text Format.")] txt,
            [Description("Uniqueness Definition File. Used for Windows unattended installations.")] udf,
            [Description("UU-encoded file.")] uue,
            [Description("Microsoft Visual basic extension.")] vbx,
            [Description("Virtual Memory file.")] vm,
            [Description("Windows 9x virtual device driver.")] vxd,
            [Description("Waveform sound file.")] wav,
            [Description("Windows Metafile (graphics format).")] wmf,
            [Description("The GIMP's native image format.")] xcf,
            [Description("Xerox Image file (same as TIFF).")] xif,
            [Description("Microsoft Excel Spreadsheet.")] xls,
            [Description("Microsoft Excel Template.")] xlt,
            [Description("Extensible markup language.")] xml,
            [Description("XML style sheet.")] xsl,
            [Description("Compressed Zip archive.")] zip,
        }

        public enum MicrosoftOffice
        {
            None,
            [Description("Microsoft Access 2007 / 2010 add -in file")] accda = 1,
            [Description("Microsoft Access 2007 / 2010 database file")] accdb,
            [Description("Microsoft Access 2007 / 2010 digitally signed database file")] accdc,
            [Description("Microsoft Access 2007 / 2010 compiled execute only file")] accde,
            [Description("Microsoft Access 2007 / 2010 project file")] accdp,
            [Description("Microsoft Access 2007 / 2010 runtime mode database file")] accdr,
            [Description("Microsoft Access 2007 / 2010 database template file")] accdt,
            [Description("Microsoft Access 2007 / 2010 database wizard file")] accdu,
            [Description("Microsoft Office automatic correction list")] acl,
            [Description("Microsoft Access compiled project file")] ade,
            [Description("icrosoft Access project file")] adp,
            [Description("Microsoft Word auto - save document file")] asd,
            [Description("Microsoft Word text conversion file")] cnv,
            [Description("Microsoft Word 97 to 2003 document file")] doc,
            [Description("Microsoft Word 2007 / 2010 Open XML macro - enabled document file")] docm,
            [Description("Microsoft Word 2007 / 2010 Open XML document file")] docx,
            [Description("Microsoft Word 97 to 2003 document template file")] dot,
            [Description("Microsoft Word 2007 / 2010 Open XML macro - enabled document template file")] dotm,
            [Description("Microsoft Word 2007 or Word 2010 XML document template file")] dotx,
            [Description("Microsoft SharePoint WorkSpace Groove file")] grv,
            [Description("Microsoft Outlook exported account and email setting file")] iaf,
            [Description("Microsoft Access 2007 / 2010 database lock file")] laccd,
            [Description("Microsoft Access form shortcut file")] maf,
            [Description("Microsoft Access macro shortcut file")] mam,
            [Description("Microsoft Access query shortcut file")] maq,
            [Description("Microsoft Access report shortcut file")] mar,
            [Description("Microsoft Access table shortcut file")] mat,
            [Description("Microsoft Access add -in file")] mda,
            [Description("Microsoft Access database file")] mdb,
            [Description("Microsoft Access compiled database(application) file")] mde,
            [Description("Microsoft Access database template file")] mdt,
            [Description("Microsoft Access workgroup information file")] mdw,
            [Description("Microsoft Project database file")] mpd,
            [Description("Microsoft Project plan file")] mpp,
            [Description("Microsoft Project template tile")] mpt,
            [Description("Microsoft Outlook offline address book file")] oab,
            [Description("Microsoft Outlook 2007 / 2010 RSS subscription file")] obi,
            [Description("Microsoft Outlook template file")] oft,
            [Description("Microsoft Outlook for Mac data file")] olm,
            [Description("Microsoft OneNote document file")] one,
            [Description("Microsoft OneNote package file")] onepk,
            [Description("Microsoft Office profile settings file")] ops,
            [Description("Microsoft Outlook inbox off - line folder file")] ost,
            [Description("Microsoft PowerPoint add -in file")] pa,
            [Description("Microsoft Office personalized settings file")] pip,
            [Description("Microsoft PowerPoint 97 to 2003 template file")] pot,
            [Description("Microsoft PowerPoint 2007 / 2010 macro - enabled Open XML template file")] potm,
            [Description("Microsoft PowerPoint 2007 / 2010 Open XML presentation template file")] potx,
            [Description("Microsoft PowerPoint 97 to 2003 add -in file")] ppa,
            [Description("Microsoft PowerPoint 2007 / 2010 macro - enabled Open XML add -in file")] ppam,
            [Description("Microsoft PowerPoint 97 to 2003 complete slide show file")] pps,
            [Description("Microsoft PowerPoint 2007 / 2010 macro - enabled Open XML complete slide show file")] ppsm,
            [Description("Microsoft PowerPoint 2007 / 2010 Open XML complete slide show file")] ppsx,
            [Description("Microsoft PowerPoint 97 to 2003 Presentation file")] ppt,
            [Description("Microsoft PowerPoint 2007 / 2010 macro - enabled Open XML presentation file")] pptm,
            [Description("Microsoft PowerPoint 2007 / 2010 Open XML presentation file")] pptx,
            [Description("Microsoft Outlook profile file")] prf,
            [Description("Microsoft Outlook personal folder file")] pst,
            [Description("Microsoft Publisher document file")] pub,
            [Description("Microsoft Publisher packed file")] puz,
            [Description("Microsoft Restricted Permission Message file")] rpmsg,
            [Description("Microsoft PowerPoint 2007 / 2010 macro - enabled Open XML slide file")] sldm,
            [Description("Microsoft PowerPoint 2007 / 2010 Open XML slide file")] sldx,
            [Description("Microsoft Symbolic Link format file")] slk,
            [Description("Microsoft Access report shapshot file")] snp,
            [Description("Microsoft Word document autosave file")] svd,
            [Description("Microsoft Office 2007 / 2010 theme file")] thmx,
            [Description("Microsoft Visio drawing XML file")] vdx,
            [Description("Microsoft Visio diagram document file")] vsd,
            [Description("Microsoft Visio smartshapes file")] vss,
            [Description("Microsoft Visio flowchart file")] vst,
            [Description("Microsoft Visio stencil XML file")] vsx,
            [Description("Microsoft Visio XML template file")] vtx,
            [Description("Microsoft Word auto - backup document file")] wbk,
            [Description("Microsoft Word add -in file")] wll,
            [Description("Microsoft Excel AutoRecover backup file")] xar,
            [Description("Microsoft Excel spreadsheet file")] xl,
            [Description("Microsoft Excel add -in file")] xla,
            [Description("Microsoft Excel 2007 / 2010 Open XML macro - enabled add -in file")] xlam,
            [Description("Microsoft Excel Toolbars file")] xlb,
            [Description("Microsoft Excel Chart file")] xlc,
            [Description("Microsoft Excel add -in file")] xll,
            [Description("Microsoft Excel Macro file")] xlm,
            [Description("Microsoft Excel 97 to 2003 workbook file")] xls,
            [Description("Microsoft Excel 2007 / 2010 binary workbook file")] xlsb,
            [Description("Microsoft Excel 2007 / 2010 Open XML macro - enabled workbook file")] xlsm,
            [Description("Microsoft Excel 2007 / 2010 Open XML workbook file")] xlsx,
            [Description("Microsoft Excel Microsoft Excel 97 to 2003 Workbook template file")] xlt,
            [Description("Microsoft Excel 2007 / 2010 Open XML macro - enabled workbook template file")] xltm,
            [Description("Microsoft Excel 2007 / 2010 Open XML workbook template file")] xltx,
            [Description("Microsoft Excel Workspace file")] xlw,
            [Description("Microsoft Office InfoPath file")] xsf,
            [Description("Microsoft Office InfoPath template form file")] xsn,
        }

        ///// <summary>
        ///// Returns a random file extension.
        ///// </summary>
        ///// <remarks>The optional <see cref="FileExtensionType"/> is a flag enumeration and you can combine different types.</remarks>
        ///// <param name="type">The type.</param>
        ///// <returns></returns>
        //public static string RandomFileExtension(FileExtensionType type = FileExtensionType.CommonFiles|FileExtensionType.MsOffice)
        //{
        //	var list = new List<string>();
        //	if ((type & FileExtensionType.CommonFiles) == FileExtensionType.CommonFiles) list.AddRange(DataStore.CommonExtensions.Keys);
        //	if ((type & FileExtensionType.MsOffice) == FileExtensionType.MsOffice) list.AddRange(DataStore.OfficeExtensions.Keys);
        //	return list[Rand.Next(list.Count)].ToLower();
        //}

        ///// <summary>
        ///// Gets the file extension description, if available.
        ///// </summary>
        ///// <param name="extension">The extension to look up.</param>
        ///// <returns></returns>
        //public static string GetFileExtensionDescription(string extension)
        //{
        //	if (DataStore.CommonExtensions.ContainsKey(extension)) return DataStore.CommonExtensions[extension];
        //	if (DataStore.OfficeExtensions.ContainsKey(extension)) return DataStore.OfficeExtensions[extension];
        //	return "Unknown file extensions.";
        //}
    }
}