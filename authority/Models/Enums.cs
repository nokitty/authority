using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public enum ReportedPersonCheckStates :byte
    {
        /// <summary>
        /// 未审核
        /// </summary>
        NotCheck=0,
        /// <summary>
        /// 审核不通过
        /// </summary>
        NotPass=1,
        /// <summary>
        /// 通过
        /// </summary>
        Pass=2
    }