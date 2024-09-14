using Xunit;

public class SoundexTests
{

  [Fact]
  public static void GenerateSoundex_ShouldReturnEmptyString_ForEmptyInput()
  {
    var newTest = new Test("Testing - Empty String", "", "");
    var result = Soundex.GenerateSoundex(Test.Name);
    Assert.Equal(result, Test.SoundexCode);
    

  }

  [Fact]
  public static void GenerateSoundex_ShouldReturnPaddedZeroes_ForSingleCharacter()
  {
    var newTest = new Test("Testing - Single Character", "A", "A000");
    var result = Soundex.GenerateSoundex(Test.Name);
    Assert.Equal(result, Test.SoundexCode);


  }

  [Fact]
  public static void GenerateSoundex_ShouldReturnMappedCode_ForAlphabeticCharacter()
  {
    var newTest = new Test("Testing - Multiple Alphabet Characters", "TOM", "T500");
    var result = Soundex.GenerateSoundex(Test.Name);
    Assert.Equal(result, Test.SoundexCode);


  }
  [Fact]
  public static void GenerateSoundex_ShouldReturnZeroesExceptFirst_ForNumbers()
  {
    var newTest = new Test("Testing - Numbers", "1234", "1000");
    var result = Soundex.GenerateSoundex(Test.Name);
    Assert.Equal(result, Test.SoundexCode);


  }
  [Fact]
  public static void GenerateSoundex_ShouldReturnZeroesExceptFirst_ForSpecialCharacters()
  {
    var newTest = new Test("Testing - Special Characters", "$#@&", "$000");
    var result = Soundex.GenerateSoundex(Test.Name);
    Assert.Equal(result, Test.SoundexCode);


  }
}

internal class Test
{
  public static string TestCaseName;
  public static string Name;
  public static string SoundexCode;

  public Test(string testcaseName, string inputName, string soundexCode)
  {
    TestCaseName = testcaseName;
    Name = inputName;
    SoundexCode = soundexCode;
  }
}
