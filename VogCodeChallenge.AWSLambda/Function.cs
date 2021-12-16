using System;
using System.IO;
using System.Text;

using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.DynamoDBv2.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace VogCodeChallenge.AWSLambda
{
    public class Function
    {
        public void FunctionHandler(DynamoDBEvent dynamoEvent)
        {
            if (dynamoEvent.Records == null)
			{
                Console.WriteLine("DynamoDBEvent has no records");
                return;
			}

            Console.WriteLine($"Beginning to process {dynamoEvent.Records.Count} records...");

            foreach (var record in dynamoEvent.Records)
            {
                Console.WriteLine($"Event ID: {record.EventID}");
                Console.WriteLine($"Event Name: {record.EventName}");
				
				// TODO: Add business logic processing the record.Dynamodb object.
            }

            Console.WriteLine("Stream processing complete.");
        }
    }
}