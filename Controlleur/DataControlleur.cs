using System;
using System.Collections.Generic;
using Vulpix;
public class DataControlleur
    {
        public void GetData(Req req, Res res){
            var fooList = new List<String>();
            fooList.Add("Hello");
            fooList.Add("World");
            res.Send(fooList);
        }
    }