using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rhino.dtech.sampleroom.cad.marker.save
    /// </summary>
    public class RhinoDtechSampleroomCadMarkerSaveRequest : BaseTopRequest<Top.Api.Response.RhinoDtechSampleroomCadMarkerSaveResponse>
    {
        /// <summary>
        /// 工艺信息
        /// </summary>
        public string ArtInfo { get; set; }

        public ArtInfoDomain ArtInfo_ { set { this.ArtInfo = TopUtils.ObjectToJson(value); } }

        /// <summary>
        /// 源文件
        /// </summary>
        public string CadSourceFile { get; set; }

        /// <summary>
        /// 排料结果
        /// </summary>
        public string MarkResultList { get; set; }

        public List<MarkResultListDomain> MarkResultList_ { set { this.MarkResultList = TopUtils.ObjectToJson(value); } }

        /// <summary>
        /// token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 白皮纸文件列表
        /// </summary>
        public string WhitePaperList { get; set; }

        /// <summary>
        /// 黄皮纸文件列表
        /// </summary>
        public string YellowPaperList { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.rhino.dtech.sampleroom.cad.marker.save";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("art_info", this.ArtInfo);
            parameters.Add("cad_source_file", this.CadSourceFile);
            parameters.Add("mark_result_list", this.MarkResultList);
            parameters.Add("token", this.Token);
            parameters.Add("white_paper_list", this.WhitePaperList);
            parameters.Add("yellow_paper_list", this.YellowPaperList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("mark_result_list", this.MarkResultList, 20);
            RequestValidator.ValidateMaxListSize("white_paper_list", this.WhitePaperList, 20);
            RequestValidator.ValidateMaxListSize("yellow_paper_list", this.YellowPaperList, 20);
        }

        /// <summary>
        /// ArtInfoDomain Data Structure.
        /// </summary>
        [Serializable]

        public class ArtInfoDomain : TopObject
        {
            /// <summary>
            /// 总床数
            /// </summary>
            [XmlElement("bed_count")]
            public Nullable<long> BedCount { get; set; }

            /// <summary>
            /// 总件数
            /// </summary>
            [XmlElement("count")]
            public Nullable<long> Count { get; set; }

            /// <summary>
            /// 裁片总数量
            /// </summary>
            [XmlElement("cut_count")]
            public Nullable<long> CutCount { get; set; }

            /// <summary>
            /// 刀口数
            /// </summary>
            [XmlElement("cut_point_count")]
            public Nullable<long> CutPointCount { get; set; }

            /// <summary>
            /// 点位个数
            /// </summary>
            [XmlElement("dot_number")]
            public Nullable<long> DotNumber { get; set; }

            /// <summary>
            /// 二度裁剪总周长
            /// </summary>
            [XmlElement("double_cut_girth")]
            public Nullable<long> DoubleCutGirth { get; set; }

            /// <summary>
            /// 单件总周长
            /// </summary>
            [XmlElement("girth")]
            public Nullable<long> Girth { get; set; }

            /// <summary>
            /// 订单总层数
            /// </summary>
            [XmlElement("order_layer_count")]
            public Nullable<long> OrderLayerCount { get; set; }
        }

        /// <summary>
        /// SizeInfoListDomain Data Structure.
        /// </summary>
        [Serializable]

        public class SizeInfoListDomain : TopObject
        {
            /// <summary>
            /// 件数
            /// </summary>
            [XmlElement("quantity")]
            public Nullable<long> Quantity { get; set; }

            /// <summary>
            /// 尺码
            /// </summary>
            [XmlElement("size")]
            public string Size { get; set; }
        }

        /// <summary>
        /// BedInfoListDomain Data Structure.
        /// </summary>
        [Serializable]

        public class BedInfoListDomain : TopObject
        {
            /// <summary>
            /// 床次
            /// </summary>
            [XmlElement("bed_number")]
            public Nullable<long> BedNumber { get; set; }

            /// <summary>
            /// 幅宽
            /// </summary>
            [XmlElement("breadth")]
            public Nullable<long> Breadth { get; set; }

            /// <summary>
            /// 件数
            /// </summary>
            [XmlElement("count")]
            public Nullable<long> Count { get; set; }

            /// <summary>
            /// 裁片数量
            /// </summary>
            [XmlElement("cut_count")]
            public Nullable<long> CutCount { get; set; }

            /// <summary>
            /// dxf文件
            /// </summary>
            [XmlElement("dxf_url")]
            public string DxfUrl { get; set; }

            /// <summary>
            /// 缩略图文件
            /// </summary>
            [XmlElement("img_url")]
            public string ImgUrl { get; set; }

            /// <summary>
            /// 层数
            /// </summary>
            [XmlElement("layer_count")]
            public Nullable<long> LayerCount { get; set; }

            /// <summary>
            /// 幅长
            /// </summary>
            [XmlElement("length")]
            public Nullable<long> Length { get; set; }

            /// <summary>
            /// 排料文件
            /// </summary>
            [XmlElement("mark_url")]
            public string MarkUrl { get; set; }

            /// <summary>
            /// plt文件
            /// </summary>
            [XmlElement("plt_url")]
            public string PltUrl { get; set; }

            /// <summary>
            /// 尺码分布
            /// </summary>
            [XmlArray("size_info_list")]
            [XmlArrayItem("size_info_list")]
            public List<SizeInfoListDomain> SizeInfoList { get; set; }
        }

        /// <summary>
        /// MarkResultListDomain Data Structure.
        /// </summary>
        [Serializable]

        public class MarkResultListDomain : TopObject
        {
            /// <summary>
            /// 床次信息
            /// </summary>
            [XmlArray("bed_info_list")]
            [XmlArrayItem("bed_info_list")]
            public List<BedInfoListDomain> BedInfoList { get; set; }

            /// <summary>
            /// 面料编码
            /// </summary>
            [XmlElement("fabric_code")]
            public string FabricCode { get; set; }

            /// <summary>
            /// 面料类型
            /// </summary>
            [XmlElement("fabric_type")]
            public string FabricType { get; set; }

            /// <summary>
            /// 是否主面料
            /// </summary>
            [XmlElement("main_fabric")]
            public Nullable<bool> MainFabric { get; set; }

            /// <summary>
            /// 用量
            /// </summary>
            [XmlElement("usage")]
            public string Usage { get; set; }
        }

        #endregion
    }
}
