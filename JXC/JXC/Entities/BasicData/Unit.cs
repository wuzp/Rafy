﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OEA.Library;
using OEA.MetaModel;
using OEA.MetaModel.Attributes;
using OEA.MetaModel.View;

namespace JXC
{
    [RootEntity, Serializable]
    public class Unit : JXCEntity
    {
        public static readonly Property<string> CodeProperty = P<Unit>.Register(e => e.Code);
        public string Code
        {
            get { return this.GetProperty(CodeProperty); }
            set { this.SetProperty(CodeProperty, value); }
        }

        public static readonly Property<string> NameProperty = P<Unit>.Register(e => e.Name);
        public string Name
        {
            get { return this.GetProperty(NameProperty); }
            set { this.SetProperty(NameProperty, value); }
        }

        public static readonly Property<string> DescriptionProperty = P<Unit>.Register(e => e.Description);
        public string Description
        {
            get { return this.GetProperty(DescriptionProperty); }
            set { this.SetProperty(DescriptionProperty, value); }
        }
    }

    [Serializable]
    public class UnitList : JXCEntityList { }

    public class UnitRepository : EntityRepository
    {
        protected UnitRepository() { }
    }

    internal class UnitConfig : EntityConfig<Unit>
    {
        protected override void ConfigMeta()
        {
            base.ConfigMeta();

            Meta.MapTable().HasColumns(
                Unit.CodeProperty,
                Unit.NameProperty,
                Unit.DescriptionProperty
                );
        }

        protected override void ConfigView()
        {
            base.ConfigView();

            View.HasLabel("计量单位").HasTitle(Unit.NameProperty);

            View.Property(Unit.CodeProperty).HasLabel("编码").ShowIn(ShowInWhere.All);
            View.Property(Unit.NameProperty).HasLabel("名称").ShowIn(ShowInWhere.All);
            View.Property(Unit.DescriptionProperty).HasLabel("单位说明").ShowIn(ShowInWhere.All);
        }
    }
}