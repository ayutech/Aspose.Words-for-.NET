' For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
Dim doc As New Document(inputFileName)
doc.Protect(ProtectionType.AllowOnlyFormFields, "password")