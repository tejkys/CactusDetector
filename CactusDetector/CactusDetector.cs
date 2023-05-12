using Tensorflow;
using Tensorflow.Keras;
using Tensorflow.Keras.ArgsDefinition;
using Tensorflow.Keras.Layers;
using static Tensorflow.Binding;
using static Tensorflow.KerasApi;

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

        string trainDataPath = @"path/to/training/folder";
        string validationDataPath = @"path/to/validation/folder";

        // Set up the image data generator to preprocess the training and validation data
        var dataGenerator = new ImageDataGenerator(rescale: 1.0 / 255, validation_split: 0.2);
        var trainGenerator = dataGenerator.FlowFromDirectory(trainDataPath, target_size: (224, 224), batch_size: 32, class_mode: "binary", subset: "training");
        var validationGenerator = dataGenerator.FlowFromDirectory(validationDataPath, target_size: (224, 224), batch_size: 32, class_mode: "binary", subset: "validation");

        // Define the model architecture using the Keras API
        var model = keras.Sequential(
            new InputLayer(input_shape: (224, 224, 3)),
            keras.layers.Conv2D(32, (3, 3), activation: "relu"),
            keras.layers.MaxPooling2D((2, 2)),
            keras.layers.Conv2D(64, (3, 3), activation: "relu"),
            keras.layers.MaxPooling2D((2, 2)),
            keras.layers.Conv2D(128, (3, 3), activation: "relu"),
            keras.layers.MaxPooling2D((2, 2)),
            keras.layers.Flatten(),
            keras.layers.Dense(128, activation: "relu"),
            keras.layers.Dense(1, activation: "sigmoid")
        );

        // Compile the model with an optimizer, loss function, and metrics
        model.Compile(optimizer: keras.optimizers.Adam(), loss: "binary_crossentropy", metrics: new[] { "accuracy" });

        // Train the model on the training data and evaluate on the validation data
        model.Fit(trainGenerator, epochs: 10, validation_data: validationGenerator);

        // Save the trained model to disk
        model.Save("path/to/saved/model");
    }


    public string Check(string modelFile, string targetImage)
    {
        return default;
    }
}