using System;
using System.Collections.Generic;
using System.Text;

namespace AES
{
    public class CloudflowConstants
    {
        public static class GroupId
        {
            public static string LEAVE = "_S_INTERNET_LEAVE";
            public static string ON_BUSINESS = "_S_INTERNET_ON_BUSINESS";
            public static string OVERTIME = "_S_INTERNET_OVERTIME";
            public static string INVOICE = "_S_INTERNET_INVOICE";
            public static string GO_OUT = "_S_INTERNET_OUT";
        }

        // 分页类型
        public static class PageType
        {
            // 第一页
            public static string FIRST = "first";
            // 最后一页
            public static string LAST = "last";
            // 前一页
            public static string PREV = "prev";
            // 后一页
            public static string NEXT = "next";
        }
    }
}   
