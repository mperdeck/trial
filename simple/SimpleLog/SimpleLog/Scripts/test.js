var log = log4javascript.getRootLogger();
var ajaxAppender = new log4javascript.AjaxAppender("/logger");

var jsonLayout = new log4javascript.JsonLayout(false, false);
jsonLayout.setCustomField('sessionId', '1.0.5');
ajaxAppender.setLayout(jsonLayout);
ajaxAppender.setBatchSize(2);

log.addAppender(ajaxAppender);

// ---

log4javascript.getLogger('testlogger.3').setLevel(log4javascript.Level.ERROR);

function btTRACE_click() {
    log.trace("trace message");
}

function btDEBUG_click() {
    log.debug("debug message");
}

function btINFO_click() {
    var log2 = log4javascript.getLogger('testlogger');
    log2.info("info message", "info message2", "info message3");
}

function btWARN_click() {
    var log3 = log4javascript.getLogger('testlogger.3');
    log3.warn("warn message");
}

function btERROR_click() 
{
    var log3a = log4javascript.getLogger('testlogger.3');
    log3a.error("error message");
}

function btFATAL_click() 
{
    log.fatal("fatal message");
}

