/*
using WebApiTest.Common;
using WebApiTest.Models.RequestModel;
using WebApiTest.Models.ResponseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;

namespace WebApiTest
{
    class Program
    {
        private const string _AppKey = "ding7nfi3xjh1zyi9mzy";
        private const string _AppSecret = "NPw2kd_61hl4dmV3iy1rUc5hY6TvC-1KnT-6febDEZ_aZgDr-Kpd8jYbsvJYJo3q";
        private static TokenResponseModel _TokenResponseModel = null;
        static async Task Main(string[] args)
        {

            //��ȡtoken https://oapi.dingtalk.com/gettoken?appkey=&appsecret=
            _TokenResponseModel = JsonConvert.DeserializeObject<TokenResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/gettoken?appkey=" + _AppKey + "&appsecret=" + _AppSecret));

            // test
            var client = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get");
            var req = new OapiUserGetRequest();
            req.Userid = "manager8674";
            req.SetHttpMethod("GET");
            var rsp = client.Execute(req, _TokenResponseModel.Access_Token);

            //��ȡ���� https://oapi.dingtalk.com/department/list?access_token=
            var departments = JsonConvert.DeserializeObject<DepartmentReponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/department/list?access_token=" + _TokenResponseModel.Access_Token));

            //ͨ�����Ż�ȡuser https://oapi.dingtalk.com/user/simplelist?access_token=&department_id=
            var users = JsonConvert.DeserializeObject<SimpleUserEResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/simplelist?access_token=" + _TokenResponseModel.Access_Token + "&department_id=1"));

            //ͨ�����Ż�ȡuserID https://oapi.dingtalk.com/user/getDeptMember?access_token=&deptId=
            var userIDs = JsonConvert.DeserializeObject<UserIDListResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/getDeptMember?access_token=" + _TokenResponseModel.Access_Token + "&deptId=1"));

            //���� https://oapi.dingtalk.com/attendance/listRecord?access_token=
            var records = JsonConvert.DeserializeObject<RecordResponseModel>(await HttpHepler.GetDataPostJsonUrlYB("https://oapi.dingtalk.com/attendance/listRecord?access_token=" + _TokenResponseModel.Access_Token, JsonConvert.SerializeObject(new RecordRequestModel()
            {
                userIds = userIDs.UserIds,
                checkDateFrom = "2020-10-20 00:00:00",
                checkDateTo = "2020-10-20 23:59:59",
                isI18n = false
            })));


            // ͨ���ֻ��Ż�ȡ userId https://oapi.dingtalk.com/user/get_by_mobile?access_token=&mobile=
            var userID = JsonConvert.DeserializeObject<UserIDResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/get_by_mobile?access_token=" + _TokenResponseModel.Access_Token + "&mobile=16657119235"));


            // ͨ��userID ��ȡ�û����� https://oapi.dingtalk.com/user/get?access_token=&userid=
            var user = JsonConvert.DeserializeObject<UserResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/get?access_token=" + _TokenResponseModel.Access_Token + "&userid=" + userID.UserID));

            Console.ReadLine();
        }
    }
}
*/
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using FastJSON;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static string appKey = "ding7nfi3xjh1zyi9mzy";
        private static string appSecret = "NPw2kd_61hl4dmV3iy1rUc5hY6TvC-1KnT-6febDEZ_aZgDr-Kpd8jYbsvJYJo3q";
        private static long agentId = 917416506L;
        private static string userId = "manager8674";
        private static long groupId = 1631985729L;
        private static string accessToken;
        static void Main(string[] args)
        {
            


            //��ȡ��AccessToken��ȡAccessToken��ҪAppkey��Appsecret,������GET
            DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            OapiGettokenRequest request = new OapiGettokenRequest();
            request.Appkey = appKey;//Appkey
            request.Appsecret = appSecret;//Appsecret
            request.SetHttpMethod("GET");
            OapiGettokenResponse response = client.Execute(request);
            //��ȡ��AccessToken
            accessToken = response.AccessToken;


            // ����Ա��
            DefaultDingTalkClient client1 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/create");
            OapiUserCreateRequest request1 = new OapiUserCreateRequest();
            request1.Userid = "zhangsan";
            request1.Mobile = "16657119236";
            request1.Email = "535497379@qq.com";
            request1.Name = "����";
            List<long> departments1 = new List<long>();
            departments1.Add(1L);
            request1.Department = JSON.ToJSON(departments1);
            OapiUserCreateResponse response1 = client1.Execute(request1, accessToken);
            Console.WriteLine("����Ա����");
            Console.WriteLine(response1.Body);
            Console.WriteLine();

            // ɾ��Ա��
            DefaultDingTalkClient client2 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/delete");
            OapiUserDeleteRequest request2 = new OapiUserDeleteRequest();
            request2.Userid = "zhangsan";
            request2.SetHttpMethod("GET");
            OapiUserDeleteResponse response2 = client2.Execute(request2, accessToken);
            Console.WriteLine("ɾ��Ա����");
            Console.WriteLine(response2.Body);
            Console.WriteLine();

            // ��ȡ�û���Ϣ
            DefaultDingTalkClient client3 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get");
            OapiUserGetRequest request3 = new OapiUserGetRequest();
            request3.Userid = userId;
            request3.SetHttpMethod("GET");
            OapiUserGetResponse response3 = client3.Execute(request3, accessToken);
            Console.WriteLine("��ȡ�û���Ϣ��");
            Console.WriteLine(response3.Body);
            Console.WriteLine();

            // ��ȡ����Ա��Ϣ
            DefaultDingTalkClient client4 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get_admin");
            OapiUserGetAdminRequest request4 = new OapiUserGetAdminRequest();
            request4.SetHttpMethod("GET");
            OapiUserGetAdminResponse response4 = client4.Execute(request4, accessToken);
            Console.WriteLine("��ȡ����Ա��Ϣ��");
            Console.WriteLine(response4.Body);
            Console.WriteLine();

            // ������ɫ
            DefaultDingTalkClient client5 = new DefaultDingTalkClient("https://oapi.dingtalk.com/role/add_role");
            OapiRoleAddRoleRequest request5 = new OapiRoleAddRoleRequest();
            request5.RoleName = "Test";
            request5.GroupId = groupId;
            OapiRoleAddRoleResponse response5 = client5.Execute(request5, accessToken);
            Console.WriteLine("������ɫ��");
            Console.WriteLine(response5.Body);
            Console.WriteLine();

            //���½�ɫ����bug����ʾ��Ҫ�޸�ΪGET���޸ĺ���Ȼ�����ȱ��CorId��APPkey�������°汾С�����Ѿ�û��CorId�ˡ�
            DefaultDingTalkClient client6 = new DefaultDingTalkClient("https://oapi.dingtalk.com/role/update_role");
            OapiRoleUpdateRoleRequest request6 = new OapiRoleUpdateRoleRequest();
            request6.RoleName = "AnyThing";
            request6.RoleId = 1;
            request6.SetHttpMethod("GET");
            OapiRoleUpdateRoleResponse response6 = client.Execute(request6, accessToken);
            Console.WriteLine("���½�ɫ");
            Console.WriteLine(response6.Body);
            Console.WriteLine();

            // ɾ����ɫ
            DefaultDingTalkClient client7 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/role/deleterole");
            OapiRoleDeleteroleRequest request7 = new OapiRoleDeleteroleRequest();
            request7.RoleId = response5.RoleId;
            OapiRoleDeleteroleResponse response7 = client7.Execute(request7, accessToken);
            Console.WriteLine("ɾ����ɫ:");
            Console.WriteLine(response7.Body);
            Console.WriteLine();

            // ����ⲿ��ϵ�� �ٷ�����������(�ѽ������Ҫ��OpenExtContactDomainǰ����request��
            // Ȼ�����������⣺���Ǻ����桰���½�ɫ���ı���һ������ʾ��ȱ�ٲ��� corpid or appkey
            DefaultDingTalkClient client8 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/extcontact/create");
            OapiExtcontactCreateRequest request8 = new OapiExtcontactCreateRequest();
            OapiExtcontactCreateRequest.OpenExtContactDomain contacter = new OapiExtcontactCreateRequest.OpenExtContactDomain();
            contacter.Title = "CFO";
            contacter.Name = "���Ե��ⲿ��ϵ��";
            contacter.StateCode = "86";
            contacter.CompanyName = "����";
            contacter.Mobile = "15295778118";
            request8.Contact = contacter.ToString();
            OapiExtcontactCreateResponse response8 = client8.Execute(request8, accessToken);
            Console.WriteLine("����ⲿ��ϵ��:");
            Console.WriteLine(response6.Body);
            Console.WriteLine();

            // ��ȡ�ⲿ��ϵ���б�
            DefaultDingTalkClient client9 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/extcontact/list");
            OapiExtcontactListRequest request9 = new OapiExtcontactListRequest();
            request9.Size = 20L;
            request9.Offset = 0L;
            OapiExtcontactListResponse response9 = client9.Execute(request9, accessToken);
            Console.WriteLine("��ȡ�ⲿ��ϵ���б�:");
            Console.WriteLine(response9.Body);
            Console.WriteLine();

            // ����Ⱥ�Ự
            DefaultDingTalkClient client10 = new DefaultDingTalkClient("https://oapi.dingtalk.com/chat/create");
            OapiChatCreateRequest request10 = new OapiChatCreateRequest();
            request10.Name = "TestCreate";
            request10.Owner = userId;
            request10.Useridlist ??= new List<string>();
            request10.Useridlist.Add(userId);
            OapiChatCreateResponse response10 = client10.Execute(request10, accessToken);
            Console.WriteLine("����Ⱥ�Ự");
            Console.WriteLine(response10.Body);
            Console.WriteLine();

            //// ��ȡȺ�Ự
            //DefaultDingTalkClient client11 = new DefaultDingTalkClient("https://oapi.dingtalk.com/chat/get");
            //OapiChatGetRequest request11 = new OapiChatGetRequest();
            //request11.Chatid = response10.Chatid;
            //request11.SetHttpMethod("GET");
            //OapiChatGetResponse response11 = client11.Execute(request11, accessToken);
            //Console.WriteLine("��ȡȺ�Ự");
            //Console.WriteLine(response11.Body);
            //Console.WriteLine();

            //// ����Ⱥ�Ի�
            //DefaultDingTalkClient client12 = new DefaultDingTalkClient("https://oapi.dingtalk.com/chat/update");
            //OapiChatUpdateRequest request12 = new OapiChatUpdateRequest();
            //request12.Chatid = response10.Chatid;
            //request12.Name = "TestUpdate";
            //OapiChatUpdateResponse response12 = client12.Execute(request12, accessToken);
            //Console.WriteLine("����Ⱥ�Ի�");
            //Console.WriteLine(response12.Body);
            //Console.WriteLine();

            // ���͹���֪ͨ
            DefaultDingTalkClient client13 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/message/corpconversation/asyncsend_v2");
            OapiMessageCorpconversationAsyncsendV2Request request13 = new OapiMessageCorpconversationAsyncsendV2Request();
            request13.AgentId = agentId;
            request13.ToAllUser = true;
            OapiMessageCorpconversationAsyncsendV2Request.MsgDomain msgDomain = new OapiMessageCorpconversationAsyncsendV2Request.MsgDomain();
            msgDomain.Msgtype = "oa";
            msgDomain.Oa = new OapiMessageCorpconversationAsyncsendV2Request.OADomain();
            msgDomain.Oa.MessageUrl = "http://dingtalk.com";
            msgDomain.Oa.Head = new OapiMessageCorpconversationAsyncsendV2Request.HeadDomain();
            msgDomain.Oa.Head.Bgcolor = "FFBBBBBB";
            msgDomain.Oa.Head.Text = "ͷ������";
            msgDomain.Oa.Body = new OapiMessageCorpconversationAsyncsendV2Request.BodyDomain();
            msgDomain.Oa.Body.Title = "���ı���";
            msgDomain.Oa.Body.Form = new List<OapiMessageCorpconversationAsyncsendV2Request.FormDomain>();
            msgDomain.Oa.Body.Form.Add(new OapiMessageCorpconversationAsyncsendV2Request.FormDomain() { Key = "����", Value = "����" });
            msgDomain.Oa.Body.Form.Add(new OapiMessageCorpconversationAsyncsendV2Request.FormDomain() { Key = "����", Value = "20" });
            msgDomain.Oa.Body.Form.Add(new OapiMessageCorpconversationAsyncsendV2Request.FormDomain() { Key = "���", Value = "1.8��" });
            msgDomain.Oa.Body.Form.Add(new OapiMessageCorpconversationAsyncsendV2Request.FormDomain() { Key = "����", Value = "130��" });
            msgDomain.Oa.Body.Form.Add(new OapiMessageCorpconversationAsyncsendV2Request.FormDomain() { Key = "ѧ��", Value = "����" });
            msgDomain.Oa.Body.Form.Add(new OapiMessageCorpconversationAsyncsendV2Request.FormDomain() { Key = "����", Value = "����������" });
            msgDomain.Oa.Body.Rich = new OapiMessageCorpconversationAsyncsendV2Request.RichDomain();
            msgDomain.Oa.Body.Rich.Num = "15.6";
            msgDomain.Oa.Body.Rich.Unit = "Ԫ";
            msgDomain.Oa.Body.Content = "����ı�����ı�����ı�����ı�����ı�";
            msgDomain.Oa.Body.Image = "@lADOADmaWMzazQKA";
            msgDomain.Oa.Body.FileCount = "3";
            msgDomain.Oa.Body.Author = "����";
            request13.Msg_ = msgDomain;
            //request13.Msg = @"{
            //    ""msgtype"": ""oa"",
            //    ""oa"": {
            //        ""message_url"": ""http://dingtalk.com"",
            //        ""head"": {
            //            ""bgcolor"": ""FFBBBBBB"",
            //            ""text"": ""ͷ������""
            //        },
            //        ""body"": {
            //            ""title"": ""���ı���"",
            //            ""form"": [
            //                {""key"": ""����:"", ""value"": ""����""},
            //                {""key"": ""����:"", ""value"": ""20""},
            //                {""key"": ""���:"", ""value"": ""1.8��""},
            //                {""key"": ""����:"", ""value"": ""130��""},
            //                {""key"": ""ѧ��:"", ""value"": ""����""},
            //                {""key"": ""����:"", ""value"": ""����������""}
            //            ],
            //            ""rich"": {""num"": ""15.6"", ""unit"": ""Ԫ""},
            //            ""content"": ""����ı�����ı�����ı�����ı�����ı�����ı�"",
            //            ""image"": ""@lADOADmaWMzazQKA"",
            //            ""file_count"": ""3"",
            //            ""author"": ""����""
            //        }
            //    }
            //}"; 
            OapiMessageCorpconversationAsyncsendV2Response response13 = client13.Execute(request13, accessToken);
            Console.WriteLine("���͹���֪ͨ:");
            Console.WriteLine(response13.Body);
            Console.WriteLine();

            //��ȡ����֪ͨ��Ϣ�ķ��ͽ���
            DefaultDingTalkClient client14 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/message/corpconversation/getsendprogress");
            OapiMessageCorpconversationGetsendprogressRequest request14 = new OapiMessageCorpconversationGetsendprogressRequest();
            request14.AgentId = agentId;
            request14.TaskId = response13.TaskId;
            OapiMessageCorpconversationGetsendprogressResponse response14 = client14.Execute(request14, accessToken);
            Console.WriteLine("��ȡ����֪ͨ��Ϣ�ķ��ͽ���");
            Console.WriteLine(response14.Body);
            Console.WriteLine();

            //��ȡ����֪ͨ��Ϣ�ķ��ͽ��
            DefaultDingTalkClient client15 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/message/corpconversation/getsendresult");
            OapiMessageCorpconversationGetsendresultRequest request15 = new OapiMessageCorpconversationGetsendresultRequest();
            request15.AgentId = agentId;
            request15.TaskId = response13.TaskId;
            OapiMessageCorpconversationGetsendresultResponse response15 = client15.Execute(request15, accessToken);
            Console.WriteLine("��ȡ����֪ͨ��Ϣ�ķ��ͽ��");
            Console.WriteLine(response15.Body);
            Console.WriteLine();

            //������Ϣ����ҵȺ(ʹ��ʱ�轫client10ע�ͻָ�)
            DefaultDingTalkClient client16 = new DefaultDingTalkClient("https://oapi.dingtalk.com/chat/send");
            OapiChatSendRequest request16 = new OapiChatSendRequest();
            request16.Chatid = response10.Chatid;
            request16.Msg = @"{
                ""msgtype"":""text"",
                ""text"": {             
                    ""content"": ""���Է�����Ϣ����ҵȺ: ����coding���ֵܣ�"",
                }
            }";
            OapiChatSendResponse response16 = client16.Execute(request16, accessToken);
            Console.WriteLine("������Ϣ����ҵȺ");
            Console.WriteLine(response16.Body);
            Console.WriteLine();



            ////���ݲ��Ż�ȡ��Urid
            //DefaultDingTalkClient clie = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/getDeptMember");
            //OapiUserGetDeptMemberRequest req = new OapiUserGetDeptMemberRequest();
            //req.DeptId = "1";
            //req.SetHttpMethod("GET");
            //OapiUserGetDeptMemberResponse rsp = clie.Execute(req, AccessToken);
            //List<string> userid = rsp.UserIds;
            ////��ȡ��Urid�����ڹ�˾��Ҫ���͵��Ǹ��˵�id
            //string Urid = userid[0];
            ////������Ϣ
            //IDingTalkClient cl = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
            //CorpMessageCorpconversationAsyncsendRequest req1 = new CorpMessageCorpconversationAsyncsendRequest();
            //req1.Msgtype = "oa";//������Ϣ����oa����ʽ���͵�,�����Ļ���text,image����ʽ
            //req1.AgentId = 917416506;//΢Ӧ��ID
            //req1.UseridList = Urid;//����Ϣ��userId,�����by��˾�����֣��ڸù�˾������һ��Ψһ��ʶ��
            //req1.ToAllUser = false;//�Ƿ񷢸�������
            //                       //��Ϣ�ı�
            ////req1.Msgcontent = "{\"message_url\": \"http://dingtalk.com\",\"head\": {\"bgcolor\": \"FFBBBBBB\",\"text\": \"ͷ������\"},\"body\": {\"title\": \"��Ǯѧϰ\",\"form\": [{\"key\": \"����:\", \"value\": \"hong\" },{\"key\": \"����:\", \"value\": \"18\" },{\"key\": \"���:\", \"value\": \"1.6��\"},{\"key\": \"����:\",\"value\": \"90��\"},{\"key\": \"ѧ��:\",\"value\": \"˶ʿ\"},{\"key\": \"����:\",\"value\": \"ѧϰ\"}],\"rich\": {\"num\": \"10000\",\"unit\": \"Ԫ\"},\"content\": \"��ȥѧϰ������\",\"file_count\": \"1\",\"author\": \"С��\"}}";
            ////CorpMessageCorpconversationAsyncsendResponse rsp1 = cl.Execute(req1, AccessToken);//������Ϣ

            //req1.Msgcontent = @"{
            //    ""message_url"": ""http://dingtalk.com"",
            //    ""head"": {""bgcolor"": ""FFBBBBBB"",""text"": ""ͷ������""},
            //    ""body"": {
            //        ""title"": ""��Ǯѧϰ"",
            //        ""form"": [
            //            {""key"": ""����:"", ""value"": ""hong"" },
            //            {""key"": ""����:"", ""value"": ""18"" },
            //            {""key"": ""���:"", ""value"": ""1.6��""},
            //            {""key"": ""����:"", ""value"": ""90��""},
            //            {""key"": ""ѧ��:"", ""value"": ""˶ʿ""},
            //            {""key"": ""����:"", ""value"": ""ѧϰ""}],
            //        ""rich"": {""num"": ""10000"",""unit"": ""Ԫ""},
            //        ""content"": ""��ȥѧϰ������"",
            //        ""file_count"": ""1"",
            //        ""author"": ""С��""
            //    }
            //}";
            //CorpMessageCorpconversationAsyncsendResponse rsp1 = cl.Execute(req1, AccessToken);//������Ϣ

            //Console.WriteLine(rsp1.Body);
            Console.ReadLine();
        }
    }
}