namespace Decideware.Logging.ServerSide
{
	public class LoggingConfiguration: ILoggingConfiguration
    {
        public string ComponentName { get; set; }

        public string ApplicationVersion { get; set; }

        /// <summary>
        /// Logging level of the logger. Only events with severity equal or higher than this will be logged.
        /// Note that this is only the initial level of the logger. It can be changed from Seq.
        /// </summary>
        public LoggingLevel LoggingLevel { get; set; }

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
		public string LogFileName { get; set; }

        /// <summary>
        /// The number of rolling log files to keep.
        /// </summary>
        public int LogFileNumberToKeep { get; set; }

        /// <summary>
        /// The maximum size of a log file in megabytes before it is rolled over.
        /// </summary>
        public double LogFileMaxMegabytes { get; set; }

        /// <summary>
        /// The subject of error emails.
        /// </summary>
        public string ErrorEmailSubject { get; set; }

        /// <summary>
        /// The SMTP server to use for error emails.
        /// Default: localhost
        /// </summary>
        public string ErrorEmailSmtpServer { get; set; }

        /// <summary>
        /// The from address to use when sending error emails.
        /// </summary>
        public string ErrorEmailSendFrom { get; set; }

        /// <summary>
        /// The address(es) to send error emails to.
        /// </summary>
        public string ErrorEmailSendTo { get; set; }

        /// <summary>
        /// The SEQ end point to send log items to
        /// </summary>
        public string SeqServer { get; set; }

        /// <summary>
        /// Identifies this application to Seq.
        /// </summary>
        public string SeqApiKey { get; set; }

        /// <summary>
        /// Identifies this application to Seq.
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// Flag indicating whether or not to send error emails.
        /// </summary>
		public bool SendEmailOnError { get; set; }

        /// <summary>
        /// Flag indicating whether or not to log errors to the flat file.
        /// </summary>
        public bool WriteToFileOnError { get; set; }

        /// <summary>
        /// Flag indicating whether or not to log errors to Seq.
        /// </summary>
        public bool WriteToSeqOnError { get; set; }

        #region Public Static Properties

        /// <summary>
        /// Gets the current instance of the logging section.
        /// </summary>
        public static LoggingConfiguration Current { get; set; }

        #endregion
    }
}

