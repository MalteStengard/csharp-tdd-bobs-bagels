using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddOneBagelTest()
    {
        Core basket = new Core();

        bool result = basket.add("plain bagel");

        int basketContent = basket.getCurrentBasketContent();

        Assert.IsTrue(result);
        Assert.That(basketContent == 1);
    }

    [Test]
    public void ChangeOrderTest()
    {
        Core basket = new Core();

        bool result = basket.add("plain bagel");

        int basketContent = basket.getCurrentBasketContent();

        Assert.IsTrue(result);
        Assert.That(basketContent == 1);

        result = basket.remove("plain bagel");

        basketContent = basket.getCurrentBasketContent();

        Assert.IsTrue(result);
        Assert.That(basketContent == 0);
    }

    [Test]
    public void FullBasketWarningTest()
    {
        Core basket = new Core();

        bool result = basket.add("plain bagel");

        int basketContent = basket.getCurrentBasketContent();

        Assert.IsTrue(result);
        Assert.That(basketContent == 1);

        result = basket.add("steak bagel");

        basketContent = basket.getCurrentBasketContent();

        Assert.IsTrue(result);
        Assert.That(basketContent == 2);

        result = basket.add("cheese bagel");

        basketContent = basket.getCurrentBasketContent();

        Assert.IsTrue(result);
        Assert.That(basketContent == 3);

        result = basket.add("plain bagel");

        Assert.IsFalse(result);
        Assert.That(basketContent == 3);
    }

    [Test]
    public void ChangeBasketCapacityTest()
    {
        Core basket = new Core();

        basket.changeBasketCapacity(2); //current is 3 by default

        int changedBasketCapacity = basket.getBasketCapacity();

        Assert.That(changedBasketCapacity == 2);

    }
}