﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using 通用访问;
using 通用访问.DTO;

namespace 通用访问.服务端测试.IBLL
{
    class B测试
    {
        public M对象 创建对象(string __名称 = "测试", string __分类 = "")
        {
            var __对象 = new M对象(__名称, __分类);
            __对象.添加属性("点结构属性1", () => "HELLO 你好!!!!!!!!");
            __对象.添加属性("点结构属性2", () => "1");
            __对象.添加属性("列结构属性", () => HJSON.序列化(new List<int> { 1, 2, 3 }), E角色.开发, new M元数据 { 类型 = "int", 结构 = E数据结构.单值数组, 默认值 = "[1,2,3]", 范围 = "1-10", });
            __对象.添加属性("行结构属性", () => HJSON.序列化(new Mdemo { 点属性 = 111, 行属性 = new Mdemo1 { 点属性1 = 1211, 点属性2 = "1221" } }));
            __对象.添加属性("表结构属性", () => HJSON.序列化(new List<Mdemo>
            {
                new Mdemo {点属性 = 111, 行属性 = new Mdemo1 {点属性1 = 1211, 点属性2 = "1221"}},
                new Mdemo {点属性 = 112, 行属性 = new Mdemo1 {点属性1 = 1212, 点属性2 = "1222"}},
            }));
            __对象.添加方法("使用单值", 实参列表 => 执行方法("使用单值", 实参列表), E角色.开发, new List<M形参>
            {
                new M形参("参数1", "int"),
                new M形参("参数2", "string"),
            }, new M元数据{ 类型 = "string", 描述="描述xxx", 结构 = E数据结构.单值, 范围 = "范围xxx" });
            __对象.添加方法("使用对象", 实参列表 => 执行方法("使用对象", 实参列表), E角色.开发, new List<M形参>
            {
                new M形参("参数1", 获取行元数据()),
            }, 获取行元数据());
            __对象.添加方法("使用单值数组", 实参列表 => 执行方法("使用单值数组", 实参列表), E角色.开发, new List<M形参>
            {
                new M形参("参数1", "int", E数据结构.单值数组),
                new M形参("参数2", "string"),
            }, new M元数据 { 类型 = "int", 描述 = "描述xxx", 结构 = E数据结构.单值数组, 范围 = "范围xxx" });
            __对象.添加方法("使用对象数组", 实参列表 => 执行方法("使用对象数组", 实参列表), E角色.开发, new List<M形参>
            {
                new M形参("参数1", 获取表元数据()),
            }, 获取表元数据());
            //__对象.添加方法("使用单值2", "参数1:int.参数2:string", "string", 实参列表 => 执行方法("使用单值", 实参列表), E角色.开发);
            //__对象.添加方法("使用对象数组2", 
            //    "参数1:,对象数组(参数1:int;参数2:string),描述.参数2:MXXX,对象(参数1:int,单值数组,xxx;参数2:string,,事大法师的).参数3:int,单值数组", 
            //    "", 
            //    实参列表 => 执行方法("使用对象数组", 实参列表), E角色.开发);
            __对象.添加方法("返回字符串表格", 实参列表 => 执行方法("返回字符串表格", 实参列表));
            __对象.添加方法("返回字符串表格2", 实参列表 => 执行方法("返回字符串表格2", 实参列表));
            return __对象;
        }

        private M元数据 获取表元数据()
        {
            var __元数据 = 获取行元数据();
            __元数据.类型 = "Mdemo";
            __元数据.结构 = E数据结构.对象数组;
            __元数据.描述 = "表结构";
            return __元数据;
        }

        private M元数据 获取行元数据()
        {
            return new M元数据
            {
                类型 = "Mdemo",
                结构 = E数据结构.对象,
                描述 = "行结构",
                默认值 = "",
                范围 = "范围1",
                子成员列表 = new List<M子成员>
                {
                    new M子成员("点属性","int"),
                    new M子成员("行属性", new M元数据
                    {
                        类型 = "Mdemo1",
                        结构 = E数据结构.对象,
                        描述 = "行结构",
                        范围 = "范围12",
                        子成员列表 = new List<M子成员>
                        {
                            new M子成员("点属性1","int"),
                            new M子成员("点属性2","string"),
                        }
                    })
                }
            };
        }

        public string 执行方法(string 方法名, Dictionary<string,string> 参数列表)
        {
            Program.F主窗口.记录(string.Format("执行方法    {0}.{1}({2})", "虚拟对象", 方法名, HJSON.序列化(参数列表)));

            if (方法名.Contains("使用对象数组"))
            {
                return HJSON.序列化(new List<Mdemo>
                {
                    new Mdemo {点属性 = 111, 行属性 = new Mdemo1 {点属性1 = 1211, 点属性2 = "1221"}},
                    new Mdemo {点属性 = 112, 行属性 = new Mdemo1 {点属性1 = 1212, 点属性2 = "1222"}},
                });
            }
            if (方法名.Contains("使用对象"))
            {
                return HJSON.序列化(new Mdemo { 点属性 = 111, 行属性 = new Mdemo1 { 点属性1 = 1211, 点属性2 = "1221" } });
            }
            if (方法名.Contains("使用单值数组"))
            {
                return HJSON.序列化(new List<int> { 1, 2, 3 });
            }
            if (方法名 == "返回字符串表格")
            {
                return "col1\tcol2\tcol3\t\r\nvalue11\tvalue12\tvalue13\t\r\nvalue21\tvalue22\tvalue23\t\r\n";
            }
            if (方法名 == "返回字符串表格2")
            {
                return @"
+----*---------*--------*----------------*-------*--------*--------*--------*--------------*--------------*------------------------+
| No |   类型  |  域名  |        IP      | 心跳  |连接状态|死亡时间|应答时间|   打包登记   |   GIS恢复    |      上次断开时间      |
+----+---------+--------+----------------+-------+--------+--------+--------+--------------+--------------+------------------------+
| 1  | DTC     | r134   |192.168.12.134  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |MON NOV 16 11:37:45 2015|
| 2  | DTC     | r20    |192.168.12.20   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 3  | DTC     | r136   |192.168.12.136  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 4  | DTC     | r29    |192.168.12.29   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 5  | DTC     | r46    |192.168.12.46   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 6  | DTC     | r42    |192.168.12.42   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 7  | DTC     | r38    |192.168.12.38   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 8  | DTC     | r68    |192.168.12.68   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 9  | DTC     | r85    |192.168.12.85   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 10 | DTC     | r81    |192.168.12.81   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 11 | DTC     | r89    |192.168.12.89   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 12 | DTC     | r88    |192.168.12.88   |在线   |ALIVE   | 29     | 0      | 打包完成     | 恢复完成     |THU JAN 01 00:00:00 1970|
| 13 | DTC     | r59    |192.168.12.59   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 14 | DTC     | r55    |192.168.12.55   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 15 | DTC     | r64    |192.168.12.64   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 16 | DTC     | r93    |192.168.12.93   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 17 | DTC     | r73    |192.168.12.73   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 18 | DTC     | r97    |192.168.12.97   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 19 | DTC     | r206   |192.168.12.206  |在线   |ALIVE   | 25     | 0      | 打包完成     | 恢复完成     |THU JAN 01 00:00:00 1970|
| 20 | DTC     | r51    |192.168.12.51   |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 21 | DTC     | r160   |192.168.12.160  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 22 | DTC     | r167   |192.168.12.167  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 23 | DTC     | r143   |192.168.12.143  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 24 | DTC     | r135   |192.168.12.135  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 25 | DTC     | r139   |192.168.12.139  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 26 | DTC     | r151   |192.168.12.151  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 27 | DTC     | r155   |192.168.12.155  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 28 | DTC     | r234   |192.168.12.234  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 29 | DTC     | r163   |192.168.12.163  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 30 | DTC     | r179   |192.168.12.179  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 31 | DTC     | r188   |192.168.12.188  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 32 | DTC     | r196   |192.168.12.196  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 33 | DTC     | r200   |192.168.12.200  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 34 | DTC     | r230   |192.168.12.230  |不在线 |UNLINK  | 0      | 0      | 等待打包     | 等待恢复     |THU JAN 01 00:00:00 1970|
| 35 | EGW10A  | x1     |192.168.12.17   |不在线 |-       | 30     | 0      | -            | -            |-                       |
| 36 | BGW     | b1     |192.168.12.56   |在线   |-       | 28     | 0      | -            | -            |-                       |
| 37 | REC     | e1     |192.168.12.3    |不在线 |-       | 30     | 0      | -            | -            |-                       |
| 38 | GIS     | g1     |192.168.12.3    |在线   |ALIVE   | 25     | 0      | -            | 恢复完成     |THU JAN 01 00:00:00 1970|
| 39 | DCS     | m26    |192.168.12.26   |不在线 |-       | 30     | 0      | -            | -            |-                       |
| 40 | DCS     | m22    |192.168.12.22   |不在线 |-       | 30     | 0      | -            | -            |-                       |
| 41 | DCS     | m24    |192.168.12.24   |不在线 |-       | 30     | 0      | -            | -            |-                       |
+----+---------+--------+----------------+-------+--------+--------+--------+--------------+--------------+------------------------+";
            }

            return "WANGKAI王凯";
        }

        public class Mdemo
        {
            public int 点属性 { get; set; }
            public Mdemo1 行属性 { get; set; }
        }

        public class Mdemo1
        {
            public int 点属性1 { get; set; }
            public string 点属性2 { get; set; }
        }

    }
}
