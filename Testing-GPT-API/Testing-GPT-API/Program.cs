using OpenAI.GPT3;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System.Security.Cryptography.X509Certificates;

namespace Testing_GPT_API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            String UserInput;

            var apiKey = "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";
            var gpt3 = new OpenAIService(new OpenAiOptions() {ApiKey = apiKey});

            Console.WriteLine("Insert Prompt: ");
            UserInput = Console.ReadLine();

            /*
            var response = openAi.Image.create(
                prompt = UserInput,
                nameof = 1,
                size="256x256"
            );
            image_url = response['data'][0]['url'];
            Console.WriteLine(image_url);
            */

            var completionResult = await gpt3.Completions.CreateCompletion(new CompletionCreateRequest()
            {
                Prompt = UserInput,
                Model = Models.TextDavinciV2,
                Temperature = 0.5F,
                MaxTokens = 100,
                N = 1
            });
            

            if (completionResult.Successful)
            {
                foreach (var choice in completionResult.Choices)
                {
                    Console.WriteLine(choice.Text);
                }
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }
                Console.WriteLine($"{completionResult.Error.Code}: {completionResult.Error.Message}");
            }

            Console.ReadLine();
        }
    }
}