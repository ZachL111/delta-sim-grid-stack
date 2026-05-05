using DeltaSimGridStack;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(80, 104, 23, 25, 9);
        if (Policy.Score(signalcase_1) != 70) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(75, 86, 24, 11, 9);
        if (Policy.Score(signalcase_2) != 138) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(73, 88, 15, 18, 4);
        if (Policy.Score(signalcase_3) != 90) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
