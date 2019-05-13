﻿using AVLCarMeasurementDemo.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;

namespace AVLCarMeasurementDemo
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<CarMeasurementContext>(opt => opt.UseInMemoryDatabase("CarMeasurements"));
      services.AddOData();
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
    }

    private static IEdmModel GetEdmModel()
    {
      ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
      builder.EntitySet<ChannelType>("ChannelTypes");
      builder.EntitySet<ChannelChartConfiguration>("ChannelChartConfigurations");
      builder.EntitySet<Measurement>("Measurements");
      builder.EntitySet<UnitUnderTest>("UnitUnderTests");
      return builder.GetEdmModel();
    }


    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseMvc(b =>
      {
        b.MapODataServiceRoute("odata", "odata", GetEdmModel());
      });
    }
  }
}