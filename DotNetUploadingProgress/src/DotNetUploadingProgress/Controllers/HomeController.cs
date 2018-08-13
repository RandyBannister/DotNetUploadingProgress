// Copyright © 2018 Michael Albanese. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFileUploading
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return this.View();
    }
  }
}