using Xunit;

namespace weekdayFinder
{
  public class weekdayFinderTests
  {
    [Fact]
    public void Find_02022016_Tuesday()
    {
      Finder f = new Finder();
      Assert.Equal("Tuesday", f.Find("02022016"));
    }
    [Fact]
    public void Find_02292016_Monday()
    {
      Finder f = new Finder();
      Assert.Equal("Monday", f.Find("02292016"));
    }
    [Fact]
    public void Find_10102016_Monday()
    {
      Finder f = new Finder();
      Assert.Equal("Monday", f.Find("10102016"));
    }
    [Fact]
    public void Find_02022000_Wednesday()
    {
      Finder f = new Finder();
      Assert.Equal("Wednesday", f.Find("02022000"));
    }
    [Fact]
    public void Find_02292000_Tuesday()
    {
      Finder f = new Finder();
      Assert.Equal("Tuesday", f.Find("02292000"));
    }
    [Fact]
    public void Find_10102000_Tuesday()
    {
      Finder f = new Finder();
      Assert.Equal("Tuesday", f.Find("10102000"));
    }
    [Fact]
    public void Find_02021900_Friday()
    {
      Finder f = new Finder();
      Assert.Equal("Friday", f.Find("02021900"));
    }
    [Fact]
    public void Find_02281900_Wednesday()
    {
      Finder f = new Finder();
      Assert.Equal("Wednesday", f.Find("02281900"));
    }
    [Fact]
    public void Find_10101900_Wednesday()
    {
      Finder f = new Finder();
      Assert.Equal("Wednesday", f.Find("10101900"));
    }
    [Fact]
    public void Find_02021965_Tuesday()
    {
      Finder f = new Finder();
      Assert.Equal("Tuesday", f.Find("02021965"));
    }
    [Fact]
    public void Find_02281965_Sunday()
    {
      Finder f = new Finder();
      Assert.Equal("Sunday", f.Find("02281965"));
    }
    [Fact]
    public void Find_10101965_Sunday()
    {
      Finder f = new Finder();
      Assert.Equal("Sunday", f.Find("10101965"));
    }
  }
}
