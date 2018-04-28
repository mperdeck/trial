namespace Decideware.Logging.ServerSide
{
	public interface ILoggingConfiguration
	{
        string ComponentName { get; }

        string ApplicationVersion { get; }

        /// <summary>
        /// Logging level of the logger. Only events with severity equal or higher than this will be logged.
        /// Note that this is only the initial level of the logger. It can be changed from Seq.
        /// </summary>
        LoggingLevel LoggingLevel { get; }

        /// <summary>
        /// The path of the log file.
        /// The {Date} does these things:
        /// * indicates that a new file will be created once a day.
        /// * acts as placeholder for the date.
        /// 
        /// IMPORTANT
        /// Do not use the directory of the log file for any files other than log files.
        /// 
        /// IMPORTANT
        /// Make sure that the part of the file name before the first . is constant, and that the extension is constant.
        /// For example, do NOT use log-{Date}.txt
        /// If you don't, the EnsureMaxNbrFiles method that prunes the files won't work.
        /// </summary>
		string LogFileName { get; }

        /// <summary>
        /// The number of rolling log files to keep.
        /// </summary>
        int LogFileNumberToKeep { get; }

        /// <summary>
        /// The maximum size of a log file in megabytes before it is rolled over.
        /// </summary>
        double LogFileMaxMegabytes { get; }

        /// <summary>
        /// The subject of error emails.
        /// </summary>
        string ErrorEmailSubject { get; }

        /// <summary>
        /// The SMTP server to use for error emails.
        /// Default: localhost
        /// </summary>
        string ErrorEmailSmtpServer { get; }

        /// <summary>
        /// The from address to use when sending error emails.
        /// </summary>
        string ErrorEmailSendFrom { get; }

        /// <summary>
        /// The address(es) to send error emails to.
        /// </summary>
        string ErrorEmailSendTo { get; }

        /// <summary>
        /// The SEQ end point to send log items to
        /// </summary>
        string SeqServer { get; }

        /// <summary>
        /// Identifies this application to Seq.
        /// </summary>
        string SeqApiKey { get; }

        /// <summary>
        /// Identifies this application to Seq.
        /// </summary>
        string Environment { get; }

        /// <summary>
        /// Flag indicating whether or not to send error emails.
        /// </summary>
		bool SendEmailOnError { get; }

        /// <summary>
        /// Flag indicating whether or not to log errors to the flat file.
        /// </summary>
        bool WriteToFileOnError { get; }

        /// <summary>
        /// Flag indicating whether or not to log errors to Seq.
        /// </summary>
        bool WriteToSeqOnError { get; }
    }
}

