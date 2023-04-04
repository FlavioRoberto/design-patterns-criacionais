using System;
namespace FluentBuilder.FluentBuilder
{
	public sealed class Email
	{
		public Email()
		{
			Body = string.Empty;
			From = string.Empty;
			Subject = string.Empty;
			To = string.Empty;
		}

        public string Body { get; set; }
		public string From { get; set; }
		public string Subject { get; set; }
		public string To { get; set; }

		public string ToString()
		{
			return $"Sending an email to: {To}\nsubject: {Subject}\nBody: {Body}\nFrom: {From}";
		}
	}
}

