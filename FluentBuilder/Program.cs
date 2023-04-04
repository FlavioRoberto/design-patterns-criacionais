// See https://aka.ms/new-console-template for more information

using FluentBuilder.FluentBuilder;

var emailBuilder = new EmailBuilder();
var email = emailBuilder.From("test@test.com")
                        .To("test2@test.com")
                        .Subject("Testing email builder")
                        .Body("Here has some text to complete the body")
                        .Create();

Console.WriteLine(email.ToString());
Console.ReadLine();

