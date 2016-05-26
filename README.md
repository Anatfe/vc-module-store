# VirtoCommerce.Store
VirtoCommerce.Store module represents stores management system.
Key features:
* multiple stores
* SEO management
* individual payment and shipping methods, tax providers management
* individual settings for each store
* customer account linking between stores
* store asset management

![image](https://cloud.githubusercontent.com/assets/7566324/15540050/edd41b2e-2285-11e6-8962-a173e002ace7.png)

# Documentation
User guide: <a href="http://docs.virtocommerce.com/x/9gDr" target="_blank">Virto Commerce Store module</a>

# Installation
Installing the module:
* Automatically: in VC Manager go to Configuration -> Modules -> Store module -> Install
* Manually: download module zip package from https://github.com/VirtoCommerce/vc-module-store/releases. In VC Manager go to Configuration -> Modules -> Advanced -> upload module package -> Install.

# Settings
* **Stores.States** - states that a store can be in (Open, Closed, Restricted Access, etc.);
* **Stores.SeoLinksType** - determines how to generate links for products and categories. Long: /grandparent-category/parent-category/my-cool-category/my-cool-product, Short: /my-cool-product, None: /product/123.

# Available resources
* Module related service implementations as a <a href="https://www.nuget.org/packages/VirtoCommerce.StoreModule.Data" target="_blank">NuGet package</a>
* API client as a <a href="" target="_blank">NuGet package **place url here**</a>
* API client documentation http://demo.virtocommerce.com/admin/docs/ui/index#!/Store_module

# License
Copyright (c) Virtosoftware Ltd.  All rights reserved.

Licensed under the Virto Commerce Open Software License (the "License"); you
may not use this file except in compliance with the License. You may
obtain a copy of the License at

http://virtocommerce.com/opensourcelicense

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
implied.
