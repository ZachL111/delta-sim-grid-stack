using DeltaSimGridStack;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(64, 33, 19, 54);
        if (DomainReviewLens.Score(item) != 158) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
