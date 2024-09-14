using Xunit;

public class SoundexTests
{
    public static string TestCaseName;
    public static string Name;
    public static string SoundexCode;

    [Fact]
    public static Test(string testcaseName, string inputName, string soundexCode)
    {
        TestCaseName = testcaseName;
        Name = inputName;
        SoundexCode = soundexCode;
    }

    [Fact]
    public static TestCaseScenario()
    {
        var testCaseList = new List<Test>
        {
            new Test("Testing - Empty String" , "", ""),
            new Test("Testing - Single Character", "A", "A000"),
            new Test("Testing - Multiple Characters", "TOM", "T500"),
            new Test("Testing - Numbers", "1234", "1000"),
            new Test("Testing - Special Characters", "$#@&", "$000")
        };

        foreach(var test in Test)
        {
            RunTests(test);
        }
    }

    [Fact]
    public static RunTests(Test)
    {
        var result = Soundex.GenerateSoundex(Test.Name);
        Assert.Equal(result, Test.SoundexCode);
        if(result == Test.SoundexCode)
        {
            Console.WriteLine("{Test.TestCaseName} : Success");
        }
        else
        {
            console.WriteLine("{Test.TestCaseName} : Failed, Expected: {Test.SoundexCode}");
        }
    }
    
   
}
