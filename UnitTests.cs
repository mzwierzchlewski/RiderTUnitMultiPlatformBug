namespace MultiTargetTUnitBug;

public class Tests
{
    [Test]
    public async Task Test()
    {
        var result = true;
        await Assert.That(result).IsTrue();
    }
}