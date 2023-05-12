namespace CactusDetector;

public class CactusDetector
{
    public CactusDetector()
    {

    }

    public void Train(string datasetFolder, string outputModelFile, Action<string> reportTraining)
    {
        reportTraining("Jo bejby");
        Thread.Sleep(1000);
    }

    public string Check(string modelFile, string targetImage)
    {
        return default;
    }
}