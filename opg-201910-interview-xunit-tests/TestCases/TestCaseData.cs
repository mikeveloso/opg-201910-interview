using System;
using System.Collections.Generic;

using opg_201910_interview.Models;

namespace OpgXunitTests.TestCases
{
    public class TestCaseData
    {
        public static IEnumerable<object[]> TestData => new List<object[]> {
                new object[] {
                    new List<ClientXmlFile>() {
                        new ClientXmlFile() {
                            ClientId = 1,
                            ClientName = "Client 1",
                            DateSeparator = "-",
                            FilePrefixSeparator = "_",
                            ValidFileDateFormat="yyyy-MM-dd",
                            XmlFilePath = "c:\\UploadedXmlFiles",
                            ValidFilePrefix = new List<string> { "waghor", "shovel", "blaze", "discus" },
                            ClientXmlFiles = new List<UploadedXmlFile>() {
                                                        new UploadedXmlFile() { FileName = "blaze_2008-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "discus_2009-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "eclair_2017-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel_2015-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel_2014-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor-2010-10-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor_2001-11-25", FileExtension = ".xml" }
                            }
                        },
                        new ClientXmlFile() {
                            ClientId = 2,
                            ClientName = "Client 2",
                            DateSeparator = "-",
                            FilePrefixSeparator = "-",
                            ValidFileDateFormat="yyyy-MM-dd",
                            XmlFilePath = "c:\\UploadedXmlFiles",
                            ValidFilePrefix = new List<string> { "orca", "widget", "eclair", "talon" },
                            ClientXmlFiles = new List<UploadedXmlFile>() {
                                                        new UploadedXmlFile() { FileName = "eclair_2017-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "eclair-2001-10-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "orca-2010-11-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "talon-2009-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "talon-2008-09-a25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "widget-2014-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "widget-2013-09-25", FileExtension = ".xml" }
                            }
                        }
                    },
                    new List<Client>() {
                        new Client() {
                            ClientId = 1,
                            ClientName = "Client 1",
                            ClientFiles = new List<ClientFile>()
                            {
                                new ClientFile() { FilePreFix = "waghor",  FileName = "waghor_2001-11-25",  FileDate = DateTime.Parse("2001-11-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel_2014-09-25", FileDate = DateTime.Parse("2014-09-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel_2015-09-25", FileDate = DateTime.Parse("2015-09-25") },
                                new ClientFile() { FilePreFix = "blaze", FileName = "blaze_2008-09-25", FileDate = DateTime.Parse("2008-09-25") },
                                new ClientFile() { FilePreFix = "discus", FileName = "discus_2009-09-25", FileDate = DateTime.Parse("2009-09-25") }
                            }
                        },
                        new Client() {
                            ClientId = 2,
                            ClientName = "Client 2",
                            ClientFiles = new List<ClientFile>()
                            {
                                new ClientFile() { FilePreFix = "orca",  FileName = "orca-2010-11-25",  FileDate = DateTime.Parse("2010-11-25") },
                                new ClientFile() { FilePreFix = "widget", FileName = "widget-2013-09-25", FileDate = DateTime.Parse("2013-09-25") },
                                new ClientFile() { FilePreFix = "widget", FileName = "widget-2014-09-25", FileDate = DateTime.Parse("2014-09-25") },
                                new ClientFile() { FilePreFix = "eclair", FileName = "eclair-2001-10-25", FileDate = DateTime.Parse("2001-10-25") },
                                new ClientFile() { FilePreFix = "talon", FileName = "talon-2009-09-25", FileDate = DateTime.Parse("2009-09-25") }
                            }
                        }
                    }
                },
                new object[] {
                    new List<ClientXmlFile>() {
                        new ClientXmlFile() {
                            ClientId = 3,
                            ClientName = "Client 3",
                            DateSeparator = "-",
                            FilePrefixSeparator = "_",
                            ValidFileDateFormat="yyyy-MM-dd",
                            XmlFilePath = "c:\\UploadedXmlFiles",
                            ValidFilePrefix = new List<string> { "waghor", "shovel", "eclair", "discus" },
                            ClientXmlFiles = new List<UploadedXmlFile>() {
                                                        new UploadedXmlFile() { FileName = "discus_2009-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "eclair_2017-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "eclair_2008-09-25a", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel_2015-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel_2014-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor-2001-10-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor_2010-11-25", FileExtension = ".xml" }
                            }
                        },
                        new ClientXmlFile() {
                            ClientId = 4,
                            ClientName = "Client 4",
                            DateSeparator = "-",
                            FilePrefixSeparator = "-",
                            ValidFileDateFormat="yyyy-MM-dd",
                            XmlFilePath = "c:\\UploadedXmlFiles",
                            ValidFilePrefix = new List<string> { "orca", "shovel", "blaze", "talon" },
                            ClientXmlFiles = new List<UploadedXmlFile>() {
                                                        new UploadedXmlFile() { FileName = "blaze-2008-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "orca-2010-11-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel-2014-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel-2013-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "talon_2017-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "talon-2001-10-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor-2010-11-25", FileExtension = ".xml" }
                            }
                        }
                    },
                    new List<Client>() {
                        new Client() {
                            ClientId = 3,
                            ClientName = "Client 3",
                            ClientFiles = new List<ClientFile>()
                            {
                                new ClientFile() { FilePreFix = "waghor",  FileName = "waghor_2010-11-25",  FileDate = DateTime.Parse("2010-11-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel_2014-09-25", FileDate = DateTime.Parse("2014-09-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel_2015-09-25", FileDate = DateTime.Parse("2015-09-25") },
                                new ClientFile() { FilePreFix = "eclair", FileName = "eclair_2017-09-25", FileDate = DateTime.Parse("2017-09-25") },
                                new ClientFile() { FilePreFix = "discus", FileName = "discus_2009-09-25", FileDate = DateTime.Parse("2009-09-25") }
                            }
                        },
                        new Client() {
                            ClientId = 4,
                            ClientName = "Client 4",
                            ClientFiles = new List<ClientFile>()
                            {
                                new ClientFile() { FilePreFix = "orca",  FileName = "orca-2010-11-25",  FileDate = DateTime.Parse("2010-11-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel-2013-09-25", FileDate = DateTime.Parse("2013-09-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel-2014-09-25", FileDate = DateTime.Parse("2014-09-25") },
                                new ClientFile() { FilePreFix = "blaze", FileName = "blaze-2008-09-25", FileDate = DateTime.Parse("2008-09-25") },
                                new ClientFile() { FilePreFix = "talon", FileName = "talon-2001-10-25", FileDate = DateTime.Parse("2001-10-25") }
                            }
                        }
                    }
                },
                new object[] {
                    new List<ClientXmlFile>() {
                        new ClientXmlFile() {
                            ClientId = 5,
                            ClientName = "Client 5",
                            DateSeparator = "-",
                            FilePrefixSeparator = "_",
                            ValidFileDateFormat="yyyy-MM-dd",
                            XmlFilePath = "c:\\UploadedXmlFiles",
                            ValidFilePrefix = new List<string> { "waghor", "shovel", "eclair", "discus" },
                            ClientXmlFiles = new List<UploadedXmlFile>() {
                                                        new UploadedXmlFile() { FileName = "discus_2009-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "eclair_2017-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "eclair_2008-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel_2015-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel_2014-a09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor-2001-10-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor_2010-11-25", FileExtension = ".xml" }
                            }
                        },
                        new ClientXmlFile() {
                            ClientId = 6,
                            ClientName = "Client 6",
                            DateSeparator = "-",
                            FilePrefixSeparator = "-",
                            ValidFileDateFormat="yyyy-MM-dd",
                            XmlFilePath = "c:\\UploadedXmlFiles",
                            ValidFilePrefix = new List<string> { "orca", "shovel", "blaze", "talon" },
                            ClientXmlFiles = new List<UploadedXmlFile>() {
                                                        new UploadedXmlFile() { FileName = "blaze-2008-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "orca-2010-11-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovels-2014-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "shovel-2013-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "talon_2017-09-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "talon-2001-10-25", FileExtension = ".xml" },
                                                        new UploadedXmlFile() { FileName = "waghor-2010-11-25", FileExtension = ".xml" }




                            }
                        }
                    },
                    new List<Client>() {
                        new Client() {
                            ClientId = 5,
                            ClientName = "Client 5",
                            ClientFiles = new List<ClientFile>()
                            {
                                new ClientFile() { FilePreFix = "waghor",  FileName = "waghor_2010-11-25",  FileDate = DateTime.Parse("2010-11-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel_2015-09-25", FileDate = DateTime.Parse("2015-09-25") },
                                new ClientFile() { FilePreFix = "eclair", FileName = "eclair_2008-09-25", FileDate = DateTime.Parse("2008-09-25") },
                                new ClientFile() { FilePreFix = "eclair", FileName = "eclair_2017-09-25", FileDate = DateTime.Parse("2017-09-25") },
                                new ClientFile() { FilePreFix = "discus", FileName = "discus_2009-09-25", FileDate = DateTime.Parse("2009-09-25") }
                            }
                        },
                        new Client() {
                            ClientId = 6,
                            ClientName = "Client 6",
                            ClientFiles = new List<ClientFile>()
                            {
                                new ClientFile() { FilePreFix = "orca",  FileName = "orca-2010-11-25",  FileDate = DateTime.Parse("2010-11-25") },
                                new ClientFile() { FilePreFix = "shovel", FileName = "shovel-2013-09-25", FileDate = DateTime.Parse("2013-09-25") },
                                new ClientFile() { FilePreFix = "blaze", FileName = "blaze-2008-09-25", FileDate = DateTime.Parse("2008-09-25") },
                                new ClientFile() { FilePreFix = "talon", FileName = "talon-2001-10-25", FileDate = DateTime.Parse("2001-10-25") },
                            }
                        }
                    }
                }
            };            
    }
}
