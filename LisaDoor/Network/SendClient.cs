using System.Net.Http.Json;

namespace LisaDoor.Network
{
    internal static class SendClient
    {
        public static void SendPOST(FileStream file)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StreamContent(file);
                var rescontent = new MultipartFormDataContent();
                rescontent.Add(content, "filename", "filename");
                rescontent.Add(new StringContent("DateTime"), "datetime");
                httpClient.PostAsJsonAsync(LisaDoor.Consts.ServerIP, rescontent);
            }
        }
    }
}
