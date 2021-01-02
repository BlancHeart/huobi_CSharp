Major differences since the time of forking:
1. You can pass HttpClient in Huobi's clients when instantiating. This allows creating and reusing the HttpClient from higher level.
2. Migrate from Newtown Json.Net to System.Text.Json. IgnoreNullValues is set to false for all property.