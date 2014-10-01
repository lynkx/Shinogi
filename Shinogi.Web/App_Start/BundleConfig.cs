using System;
using System.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(
    typeof(Shinogi.Web.BundleConfig), "PreStart")]

namespace Shinogi.Web
{
    public class BundleConfig
    {

        public static void PreStart()
        {
            // Add your start logic here
            RegisterBundles();
        }

        public static void RegisterBundles()
        {
            var bundles = BundleTable.Bundles;
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);


            bundles.Add(
                    new ScriptBundle("~/Scripts/vendor")
                        .Include("~/Scripts/jquery-1.{version}.js")
                        .Include("~/Scripts/bootstrap.js")
                        .Include("~/Scripts/knockout-{version}.js")
                        .Include("~/Scripts/knockout.utils.js")
                        .Include("~/Scripts/moment.js")
                        .Include("~/Scripts/bootstrap-datetimepicker.js")
                        .Include("~/Scripts/locales/datetimepickers.locales.sr.js")
                        .Include("~/Scripts/ko.bindings.date.js")
                        .Include("~/Scripts/ko.bindings.datepicker.js")
                        .Include("~/Scripts/ko.bindings.currency.js")
                        .Include("~/Scripts/ko.extends.distinct.js")
                        .Include("~/Scripts/q.js")
                        .Include("~/Scripts/breeze.min.js")
                        .Include("~/Scripts/breeze.debug.js")
                        .Include("~/Scripts/toastr.js")
                        .Include("~/Scripts/globals.js")
                    );

            bundles.Add(
              new StyleBundle("~/Content/css")
                .Include("~/Content/ie10mobile.css")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Content/bootstrap-theme.min.css")
                .Include("~/Content/font-awesome.min.css")
                .Include("~/Content/bootstrap-datetimepicker.min.css")
                .Include("~/Content/dashboard.min.css")
                .Include("~/Content/durandal.css")
                .Include("~/Content/custom.css")
                .Include("~/Content/toastr.min.css")

              );
        }

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
            {
                throw new ArgumentNullException("ignoreList");
            }

            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}