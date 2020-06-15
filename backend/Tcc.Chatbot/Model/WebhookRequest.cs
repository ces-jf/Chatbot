using System.Collections.Generic;

public class Parameters
{
    public string cursos { get; set; }
    public string periodos { get; set; }
}

public class Text
{
    public IList<string> text { get; set; }
}

public class FulfillmentMessage
{
    public Text text { get; set; }
}

public class OutputContext
{
    public string name { get; set; }
    public int lifespanCount { get; set; }
    public Dictionary<string, string> parameters { get; set; }
}

public class Intent
{
    public string name { get; set; }
    public string displayName { get; set; }
}

public class QueryResult
{
    public string queryText { get; set; }
    public string action { get; set; }
    public Parameters parameters { get; set; }
    public bool allRequiredParamsPresent { get; set; }
    public string fulfillmentText { get; set; }
    public IList<FulfillmentMessage> fulfillmentMessages { get; set; }
    public IList<OutputContext> outputContexts { get; set; }
    public Intent intent { get; set; }
    public double intentDetectionConfidence { get; set; }
    public string languageCode { get; set; }
}

public class WebhookRequest
{
    public string responseId { get; set; }
    public QueryResult queryResult { get; set; }
    public string session { get; set; }
}

