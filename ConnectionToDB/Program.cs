using ConnectionToDB;
using ConnectionToDB.Models.Dto_models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Text;

internal class Program
{
    static ApplicationContext db = new ApplicationContext();
    static HttpClient _httpClient = new HttpClient();
    const string _apiUrl = @"http://10.241.0.164:443/api/TestOrder/AddSampleDb"; 

    static async Task Main()
    {
        try
        {
            while (true)
            {
                List<TestOrderLinesDto> testOrderLinesDtos = db.test_order_lines.Where(x => x.Status == "Новая").ToList();

                foreach (var a in testOrderLinesDtos)
                {
                    TestOrderLinesDto testOrderLinesDto = new TestOrderLinesDto()
                    {
                        Id = a.Id,
                        Descriptions = db.desc.Where(x => x.TestOrderLinesDtoId == a.Id).ToList(),
                        DocumentRouteSteps = db.doc_route_step_t.Where(x => x.TestOrderLinesDtoId == a.Id).ToList(),
                        TestOrderLineT = GetList(a),
                        MessageEventType = a.MessageEventType,
                        DocumentDate = a.DocumentDate,
                        DstUnitCode = a.DstUnitCode,
                        Name = a.Name,
                        No = a.No,
                        TestOrderGuid = a.TestOrderGuid,
                        UnitCode = a.UnitCode,
                        Status = "В работе",
                    };

                    bool bol = await UpdateOrder(testOrderLinesDto);
                    if (bol)
                    {
                        a.Status = "В работе";
                        db.test_order_lines.Update(a);
                        db.SaveChanges();
                    }
                    else
                    {

                    }
                    Thread.Sleep(3000);
                }

                Thread.Sleep(180000);
            }
    }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
            Console.ReadLine();
        }
    }

    public static List<TestOrderLineTDto> GetList(TestOrderLinesDto test)
    {
        List<TestOrderLineTDto> abs = db.test_order_line_t.Where(x => x.TestOrderLinesDtoId == test.Id).ToList();
        List<TestOrderLineTDto> m = new List<TestOrderLineTDto>();

        foreach (var a in abs)
        {
            m.Add(new TestOrderLineTDto()
            {
                Id = a.Id,
                TestOrderLinesDtoId = a.TestOrderLinesDtoId,
                MaxValue = a.MaxValue,
                MinValue = a.MinValue,
                RefGuid = a.RefGuid,
                StringValue = a.StringValue,
                TestDate = a.TestDate,
                TestOrderLineGuid = a.TestOrderLineGuid,
                TestResultGuid = a.TestResultGuid,
                TestTypeGuid = a.TestTypeGuid,
                TestTypeKindGuid = a.TestTypeKindGuid,
                UnitMeas = a.UnitMeas,
                Descriptions = db.desc.Where(x => x.TestOrderLineTDtoId == a.Id).ToList(),
            });
        }
        return m;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="TestOrder"></param>
    /// <returns></returns>
    public static async Task<bool> UpdateOrder(TestOrderLinesDto TestOrder)
    {
        var json = JsonConvert.SerializeObject(TestOrder);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync(_apiUrl, content);
        if (response.IsSuccessStatusCode)
        {
            await Console.Out.WriteLineAsync("Заявка: " + TestOrder.No + " принята");
            return true;
        }
        else
        {
            await Console.Out.WriteLineAsync(TestOrder.No + " " + response.Content.ToString());
            return false;
        }
    }
}