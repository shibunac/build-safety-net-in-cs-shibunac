using Xunit;

public class SoundexTests
{
    public static string TestCaseName
    public static string Name;
    public static string Code;

    public static Test(string testcaseName, string inputName, string soundexCode)
    {
        TestCaseName = testcaseName
        Name = inputName;
        Code = soundexCode;
    }

    public static TestCaseScenario()
    {
        var testCaseList = new List<Test>
        {
            new Test("Test - Empty String" , "", "");
            new Test("Test - Single Character", "A", "A000");
        };

        foreach(var test in Test)
        {
            RunTests(test)
        }
    }

    [Fact]
    public static RunTests()
    {
        var result = Soundex.GenerateSoundex(Name);
        Assert.Equal(result, Code)
        if(result == Code)
        {
            Console.WriteLine("{TestCaseName} : Success");
        }
        else
        {
            console.WriteLine("{TestCaseName} : Failed, Expected: {Code}");
        }
    }
    
   
}
