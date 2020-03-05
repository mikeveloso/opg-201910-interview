using System.Collections.Generic;

using Xunit;

using opg_201910_interview.Helpers;
using opg_201910_interview.Models;

using OpgXunitTests.TestCases;

namespace OpgXunitTests
{
    public class OpgXmlFileTest
    {
        [Theory]
        [MemberData(nameof(TestCaseData.TestData), MemberType = typeof(TestCaseData))]
        public void ClientXmlFileTest(List<ClientXmlFile> clientXmlFiles, List<Client> expectedResults)
        {
            List<Client> clients = ClientHelper.GetClientFiles(clientXmlFiles);

            Assert.Equal(expectedResults, clients);
        }
    }
}