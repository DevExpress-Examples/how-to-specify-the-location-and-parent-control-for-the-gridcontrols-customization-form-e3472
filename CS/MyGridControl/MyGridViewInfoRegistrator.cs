using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Registrator;



namespace DevExpress.MyControl
{
    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName 
        { 
            get { return "MyGridView"; } 
        }



        public override BaseView CreateView(GridControl grid) 
        { 
            return new MyGridView(grid as GridControl); 
        }
    }
}
