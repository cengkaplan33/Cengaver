(function() {
	'use strict';
	var $asm = {};
	global.Cengaver = global.Cengaver || {};
	global.Cengaver.Administration = global.Cengaver.Administration || {};
	global.Cengaver.Common = global.Cengaver.Common || {};
	global.Cengaver.Membership = global.Cengaver.Membership || {};
	global.Cengaver.Northwind = global.Cengaver.Northwind || {};
	global.Cengaver.TvHastanesi = global.Cengaver.TvHastanesi || {};
	ss.initAssembly($asm, 'Cengaver.Script');
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.ScriptInitialization
	var $Cengaver_ScriptInitialization = function() {
	};
	$Cengaver_ScriptInitialization.__typeName = 'Cengaver.ScriptInitialization';
	global.Cengaver.ScriptInitialization = $Cengaver_ScriptInitialization;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.LanguageDialog
	var $Cengaver_Administration_LanguageDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Administration_LanguageDialog.__typeName = 'Cengaver.Administration.LanguageDialog';
	global.Cengaver.Administration.LanguageDialog = $Cengaver_Administration_LanguageDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.LanguageForm
	var $Cengaver_Administration_LanguageForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Administration_LanguageForm.__typeName = 'Cengaver.Administration.LanguageForm';
	global.Cengaver.Administration.LanguageForm = $Cengaver_Administration_LanguageForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.LanguageGrid
	var $Cengaver_Administration_LanguageGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Administration_LanguageGrid.__typeName = 'Cengaver.Administration.LanguageGrid';
	global.Cengaver.Administration.LanguageGrid = $Cengaver_Administration_LanguageGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.LanguageService
	var $Cengaver_Administration_LanguageService = function() {
	};
	$Cengaver_Administration_LanguageService.__typeName = 'Cengaver.Administration.LanguageService';
	$Cengaver_Administration_LanguageService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Language/Create', request, onSuccess, options);
	};
	$Cengaver_Administration_LanguageService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Language/Update', request, onSuccess, options);
	};
	$Cengaver_Administration_LanguageService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Language/Delete', request, onSuccess, options);
	};
	$Cengaver_Administration_LanguageService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Language/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Administration_LanguageService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Language/List', request, onSuccess, options);
	};
	global.Cengaver.Administration.LanguageService = $Cengaver_Administration_LanguageService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.PermissionCheckEditor
	var $Cengaver_Administration_PermissionCheckEditor = function(div) {
		this.$containsText = null;
		ss.makeGenericType(Serenity.CheckTreeEditor$1, [Object]).call(this, div, null);
	};
	$Cengaver_Administration_PermissionCheckEditor.__typeName = 'Cengaver.Administration.PermissionCheckEditor';
	global.Cengaver.Administration.PermissionCheckEditor = $Cengaver_Administration_PermissionCheckEditor;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.PermissionModuleEditor
	var $Cengaver_Administration_PermissionModuleEditor = function(hidden) {
		ss.makeGenericType(Serenity.Select2Editor$2, [Object, String]).call(this, hidden, null);
		var modules = {};
		var permissions = Q.getRemoteData('Administration.PermissionKeys').Entities;
		for (var i = 0; i < permissions.length; i++) {
			var k = permissions[i];
			var idx1 = k.indexOf(String.fromCharCode(58));
			if (idx1 <= 0) {
				continue;
			}
			var idx2 = k.indexOf(String.fromCharCode(58), idx1 + 1);
			if (idx2 <= 0) {
				continue;
			}
			var module = k.substr(0, idx1);
			modules[module] = true;
		}
		var othersModule = false;
		for (var $t1 = 0; $t1 < permissions.length; $t1++) {
			var k1 = permissions[$t1];
			var idx11 = k1.indexOf(String.fromCharCode(58));
			if (idx11 < 0 && !ss.isValue(modules[k1])) {
				othersModule = true;
				break;
			}
		}
		var moduleList = [];
		ss.arrayAddRange(moduleList, Object.keys(modules));
		if (othersModule) {
			moduleList.push('Common');
		}
		for (var $t2 = 0; $t2 < moduleList.length; $t2++) {
			var k2 = moduleList[$t2];
			this.addItem(k2, k2, k2, false);
		}
	};
	$Cengaver_Administration_PermissionModuleEditor.__typeName = 'Cengaver.Administration.PermissionModuleEditor';
	global.Cengaver.Administration.PermissionModuleEditor = $Cengaver_Administration_PermissionModuleEditor;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.RoleCheckEditor
	var $Cengaver_Administration_RoleCheckEditor = function(div) {
		this.$containsText = null;
		ss.makeGenericType(Serenity.CheckTreeEditor$1, [Object]).call(this, div, null);
	};
	$Cengaver_Administration_RoleCheckEditor.__typeName = 'Cengaver.Administration.RoleCheckEditor';
	global.Cengaver.Administration.RoleCheckEditor = $Cengaver_Administration_RoleCheckEditor;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.RoleDialog
	var $Cengaver_Administration_RoleDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Administration_RoleDialog.__typeName = 'Cengaver.Administration.RoleDialog';
	global.Cengaver.Administration.RoleDialog = $Cengaver_Administration_RoleDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.RoleForm
	var $Cengaver_Administration_RoleForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Administration_RoleForm.__typeName = 'Cengaver.Administration.RoleForm';
	global.Cengaver.Administration.RoleForm = $Cengaver_Administration_RoleForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.RoleGrid
	var $Cengaver_Administration_RoleGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Administration_RoleGrid.__typeName = 'Cengaver.Administration.RoleGrid';
	global.Cengaver.Administration.RoleGrid = $Cengaver_Administration_RoleGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.RolePermissionDialog
	var $Cengaver_Administration_RolePermissionDialog = function(opt) {
		this.$permissions = null;
		ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).$ctor1.call(this, opt);
		this.$permissions = new $Cengaver_Administration_PermissionCheckEditor(this.byId$1('Permissions'));
		$Cengaver_Administration_RolePermissionService.list({ RoleID: this.options.roleID, Module: null, Submodule: null }, ss.mkdel(this, function(response) {
			this.$permissions.set_value(response.Entities);
		}), null);
	};
	$Cengaver_Administration_RolePermissionDialog.__typeName = 'Cengaver.Administration.RolePermissionDialog';
	global.Cengaver.Administration.RolePermissionDialog = $Cengaver_Administration_RolePermissionDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.RolePermissionService
	var $Cengaver_Administration_RolePermissionService = function() {
	};
	$Cengaver_Administration_RolePermissionService.__typeName = 'Cengaver.Administration.RolePermissionService';
	$Cengaver_Administration_RolePermissionService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/RolePermission/Update', request, onSuccess, options);
	};
	$Cengaver_Administration_RolePermissionService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/RolePermission/List', request, onSuccess, options);
	};
	global.Cengaver.Administration.RolePermissionService = $Cengaver_Administration_RolePermissionService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.RoleService
	var $Cengaver_Administration_RoleService = function() {
	};
	$Cengaver_Administration_RoleService.__typeName = 'Cengaver.Administration.RoleService';
	$Cengaver_Administration_RoleService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Role/Create', request, onSuccess, options);
	};
	$Cengaver_Administration_RoleService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Role/Update', request, onSuccess, options);
	};
	$Cengaver_Administration_RoleService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Role/Delete', request, onSuccess, options);
	};
	$Cengaver_Administration_RoleService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Role/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Administration_RoleService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Role/List', request, onSuccess, options);
	};
	global.Cengaver.Administration.RoleService = $Cengaver_Administration_RoleService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.TranslationGrid
	var $Cengaver_Administration_TranslationGrid = function(container) {
		this.$searchText = null;
		this.$sourceLanguage = null;
		this.$targetLanguage = null;
		this.$targetLanguageKey = null;
		this.$hasChanges = false;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
		this.element.on('keyup.' + this.uniqueName + ' change.' + this.uniqueName, 'input.custom-text', ss.mkdel(this, function(e) {
			var value = Q.trimToNull($(e.target).val());
			if (value === '') {
				value = null;
			}
			this.view.getItemById($(e.target).data('key')).CustomText = value;
			this.$hasChanges = true;
		}));
	};
	$Cengaver_Administration_TranslationGrid.__typeName = 'Cengaver.Administration.TranslationGrid';
	global.Cengaver.Administration.TranslationGrid = $Cengaver_Administration_TranslationGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.TranslationService
	var $Cengaver_Administration_TranslationService = function() {
	};
	$Cengaver_Administration_TranslationService.__typeName = 'Cengaver.Administration.TranslationService';
	$Cengaver_Administration_TranslationService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Translation/List', request, onSuccess, options);
	};
	$Cengaver_Administration_TranslationService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/Translation/Update', request, onSuccess, options);
	};
	global.Cengaver.Administration.TranslationService = $Cengaver_Administration_TranslationService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserDialog
	var $Cengaver_Administration_UserDialog = function() {
		this.$form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.$form = new $Cengaver_Administration_UserForm(this.get_idPrefix());
		Serenity.VX.addValidationRule(this.$form.get_password(), this.uniqueName, ss.mkdel(this, function(e) {
			if (this.$form.get_password().get_value().length < 7) {
				return 'Password must be at least 7 characters!';
			}
			return null;
		}));
		Serenity.VX.addValidationRule(this.$form.get_passwordConfirm(), this.uniqueName, ss.mkdel(this, function(e1) {
			if (!ss.referenceEquals(this.$form.get_password().get_value(), this.$form.get_passwordConfirm().get_value())) {
				return "The passwords entered doesn't match!";
			}
			return null;
		}));
	};
	$Cengaver_Administration_UserDialog.__typeName = 'Cengaver.Administration.UserDialog';
	global.Cengaver.Administration.UserDialog = $Cengaver_Administration_UserDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserForm
	var $Cengaver_Administration_UserForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Administration_UserForm.__typeName = 'Cengaver.Administration.UserForm';
	global.Cengaver.Administration.UserForm = $Cengaver_Administration_UserForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserGrid
	var $Cengaver_Administration_UserGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Administration_UserGrid.__typeName = 'Cengaver.Administration.UserGrid';
	global.Cengaver.Administration.UserGrid = $Cengaver_Administration_UserGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserPermissionDialog
	var $Cengaver_Administration_UserPermissionDialog = function(opt) {
		this.$permissions = null;
		ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).$ctor1.call(this, opt);
		this.$permissions = new $Cengaver_Administration_PermissionCheckEditor(this.byId$1('Permissions'));
		$Cengaver_Administration_UserPermissionService.list({ UserID: this.options.userID, Module: null, Submodule: null }, ss.mkdel(this, function(response) {
			this.$permissions.set_value(response.Entities);
		}), null);
	};
	$Cengaver_Administration_UserPermissionDialog.__typeName = 'Cengaver.Administration.UserPermissionDialog';
	global.Cengaver.Administration.UserPermissionDialog = $Cengaver_Administration_UserPermissionDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserPermissionService
	var $Cengaver_Administration_UserPermissionService = function() {
	};
	$Cengaver_Administration_UserPermissionService.__typeName = 'Cengaver.Administration.UserPermissionService';
	$Cengaver_Administration_UserPermissionService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/UserPermission/Update', request, onSuccess, options);
	};
	$Cengaver_Administration_UserPermissionService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/UserPermission/List', request, onSuccess, options);
	};
	$Cengaver_Administration_UserPermissionService.listPermissionKeys = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/UserPermission/ListPermissionKeys', request, onSuccess, options);
	};
	global.Cengaver.Administration.UserPermissionService = $Cengaver_Administration_UserPermissionService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserRoleDialog
	var $Cengaver_Administration_UserRoleDialog = function(opt) {
		this.$permissions = null;
		ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).$ctor1.call(this, opt);
		this.$permissions = new $Cengaver_Administration_RoleCheckEditor(this.byId$1('Roles'));
		$Cengaver_Administration_UserRoleService.list({ UserID: this.options.userID }, ss.mkdel(this, function(response) {
			this.$permissions.set_value(Enumerable.from(response.Entities).select(function(x) {
				return x.toString();
			}).toArray());
		}), null);
	};
	$Cengaver_Administration_UserRoleDialog.__typeName = 'Cengaver.Administration.UserRoleDialog';
	global.Cengaver.Administration.UserRoleDialog = $Cengaver_Administration_UserRoleDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserRoleService
	var $Cengaver_Administration_UserRoleService = function() {
	};
	$Cengaver_Administration_UserRoleService.__typeName = 'Cengaver.Administration.UserRoleService';
	$Cengaver_Administration_UserRoleService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/UserRole/Update', request, onSuccess, options);
	};
	$Cengaver_Administration_UserRoleService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/UserRole/List', request, onSuccess, options);
	};
	global.Cengaver.Administration.UserRoleService = $Cengaver_Administration_UserRoleService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Administration.UserService
	var $Cengaver_Administration_UserService = function() {
	};
	$Cengaver_Administration_UserService.__typeName = 'Cengaver.Administration.UserService';
	$Cengaver_Administration_UserService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/User/Create', request, onSuccess, options);
	};
	$Cengaver_Administration_UserService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/User/Update', request, onSuccess, options);
	};
	$Cengaver_Administration_UserService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/User/Delete', request, onSuccess, options);
	};
	$Cengaver_Administration_UserService.undelete = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/User/Undelete', request, onSuccess, options);
	};
	$Cengaver_Administration_UserService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/User/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Administration_UserService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Administration/User/List', request, onSuccess, options);
	};
	global.Cengaver.Administration.UserService = $Cengaver_Administration_UserService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Common.CascadedEditorHelper
	var $Cengaver_Common_CascadedEditorHelper$2 = function(TWidget, TParentWidget) {
		var $type = function(widget, getParentValue, updateItems) {
			this.$widget = null;
			this.$updateItems = null;
			this.$parentID = null;
			this.$parentValue = null;
			this.$getParentValue = null;
			this.$widget = widget;
			this.$updateItems = updateItems;
			this.$getParentValue = getParentValue;
		};
		ss.registerGenericClassInstance($type, $Cengaver_Common_CascadedEditorHelper$2, [TWidget, TParentWidget], {
			bindToParent: function() {
				if (Q.isEmptyOrNull(this.get_parentID())) {
					return;
				}
				var parent = Serenity.WX.tryGetWidget(TParentWidget).call(null, Q.findElementWithRelativeId(this.$widget.get_element(), this.get_parentID()));
				if (ss.isValue(parent)) {
					parent.get_element().bind('change.' + this.$widget.get_uniqueName(), ss.mkdel(this, function() {
						this.set_parentValue(this.$getParentValue(parent));
					}));
				}
			},
			unbindFromParent: function() {
				if (Q.isEmptyOrNull(this.get_parentID())) {
					return;
				}
				var parent = Serenity.WX.tryGetWidget(TParentWidget).call(null, Q.findElementWithRelativeId(this.$widget.get_element(), this.get_parentID()));
				if (ss.isValue(parent)) {
					parent.get_element().unbind('.' + this.$widget.get_uniqueName());
				}
			},
			get_parentID: function() {
				return this.$parentID;
			},
			set_parentID: function(value) {
				if (!ss.referenceEquals(this.$parentID, value)) {
					this.unbindFromParent();
					this.$parentID = value;
					this.bindToParent();
					this.$updateItems();
				}
			},
			get_parentValue: function() {
				return this.$parentValue;
			},
			set_parentValue: function(value) {
				if (!ss.referenceEquals(ss.coalesce(this.$parentValue, '').toString(), ss.coalesce(value, '').toString())) {
					this.$parentValue = value;
					this.$updateItems();
				}
			}
		}, function() {
			return null;
		}, function() {
			return [];
		});
		return $type;
	};
	$Cengaver_Common_CascadedEditorHelper$2.__typeName = 'Cengaver.Common.CascadedEditorHelper$2';
	ss.initGenericClass($Cengaver_Common_CascadedEditorHelper$2, $asm, 2);
	global.Cengaver.Common.CascadedEditorHelper$2 = $Cengaver_Common_CascadedEditorHelper$2;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Common.LanguageSelection
	var $Cengaver_Common_LanguageSelection = function(hidden, currentLanguage) {
		this.$currentLanguage = null;
		ss.makeGenericType(Serenity.LookupEditorBase$1, [Object]).call(this, hidden);
		this.$currentLanguage = ss.coalesce(currentLanguage, 'en');
		this.set_value('en');
		var self = this;
		Serenity.WX.changeSelect2(this, function(e) {
			$.cookie('LanguagePreference', self.get_value(), { path: Q$Config.applicationPath });
			window.location.reload(true);
		});
	};
	$Cengaver_Common_LanguageSelection.__typeName = 'Cengaver.Common.LanguageSelection';
	global.Cengaver.Common.LanguageSelection = $Cengaver_Common_LanguageSelection;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Common.SidebarSearch
	var $Cengaver_Common_SidebarSearch = function(input, menuUL) {
		this.$menuUL = null;
		Serenity.Widget.call(this, input);
		var self = this;
		var $t1 = Serenity.QuickSearchInputOptions.$ctor();
		$t1.onSearch = function(field, text) {
			self.$updateMatchFlags(text);
		};
		new Serenity.QuickSearchInput(input, $t1);
		this.$menuUL = menuUL;
	};
	$Cengaver_Common_SidebarSearch.__typeName = 'Cengaver.Common.SidebarSearch';
	global.Cengaver.Common.SidebarSearch = $Cengaver_Common_SidebarSearch;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Membership.LoginForm
	var $Cengaver_Membership_LoginForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Membership_LoginForm.__typeName = 'Cengaver.Membership.LoginForm';
	global.Cengaver.Membership.LoginForm = $Cengaver_Membership_LoginForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Membership.LoginPanel
	var $Cengaver_Membership_LoginPanel = function() {
		ss.makeGenericType(Serenity.PropertyDialog$1, [Object]).call(this);
		this.byId$1('LoginButton').click(ss.thisFix(ss.mkdel(this, function(s, e) {
			e.preventDefault();
			if (!this.validateForm()) {
				return;
			}
			var request = this.getSaveEntity();
			Q.serviceCall({
				url: Q.resolveUrl('~/Account/Login'),
				request: request,
				onSuccess: function(response) {
					var q = Q$Externals.parseQueryString();
					var $t1 = q['returnUrl'];
					if (ss.isNullOrUndefined($t1)) {
						$t1 = q['ReturnUrl'];
					}
					var r = $t1;
					if (!ss.isNullOrEmptyString(r)) {
						window.location.href = r;
					}
					else {
						window.location.href = Q.resolveUrl('~/');
					}
				}
			});
		})));
	};
	$Cengaver_Membership_LoginPanel.__typeName = 'Cengaver.Membership.LoginPanel';
	global.Cengaver.Membership.LoginPanel = $Cengaver_Membership_LoginPanel;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CategoryDialog
	var $Cengaver_Northwind_CategoryDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_CategoryDialog.__typeName = 'Cengaver.Northwind.CategoryDialog';
	global.Cengaver.Northwind.CategoryDialog = $Cengaver_Northwind_CategoryDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CategoryForm
	var $Cengaver_Northwind_CategoryForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_CategoryForm.__typeName = 'Cengaver.Northwind.CategoryForm';
	global.Cengaver.Northwind.CategoryForm = $Cengaver_Northwind_CategoryForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CategoryGrid
	var $Cengaver_Northwind_CategoryGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_CategoryGrid.__typeName = 'Cengaver.Northwind.CategoryGrid';
	global.Cengaver.Northwind.CategoryGrid = $Cengaver_Northwind_CategoryGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CategoryService
	var $Cengaver_Northwind_CategoryService = function() {
	};
	$Cengaver_Northwind_CategoryService.__typeName = 'Cengaver.Northwind.CategoryService';
	$Cengaver_Northwind_CategoryService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Category/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_CategoryService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Category/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_CategoryService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Category/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_CategoryService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Category/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_CategoryService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Category/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.CategoryService = $Cengaver_Northwind_CategoryService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerCustomerDemoDialog
	var $Cengaver_Northwind_CustomerCustomerDemoDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_CustomerCustomerDemoDialog.__typeName = 'Cengaver.Northwind.CustomerCustomerDemoDialog';
	global.Cengaver.Northwind.CustomerCustomerDemoDialog = $Cengaver_Northwind_CustomerCustomerDemoDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerCustomerDemoForm
	var $Cengaver_Northwind_CustomerCustomerDemoForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_CustomerCustomerDemoForm.__typeName = 'Cengaver.Northwind.CustomerCustomerDemoForm';
	global.Cengaver.Northwind.CustomerCustomerDemoForm = $Cengaver_Northwind_CustomerCustomerDemoForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerCustomerDemoGrid
	var $Cengaver_Northwind_CustomerCustomerDemoGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_CustomerCustomerDemoGrid.__typeName = 'Cengaver.Northwind.CustomerCustomerDemoGrid';
	global.Cengaver.Northwind.CustomerCustomerDemoGrid = $Cengaver_Northwind_CustomerCustomerDemoGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerCustomerDemoService
	var $Cengaver_Northwind_CustomerCustomerDemoService = function() {
	};
	$Cengaver_Northwind_CustomerCustomerDemoService.__typeName = 'Cengaver.Northwind.CustomerCustomerDemoService';
	$Cengaver_Northwind_CustomerCustomerDemoService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerCustomerDemo/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerCustomerDemoService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerCustomerDemo/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerCustomerDemoService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerCustomerDemo/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerCustomerDemoService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerCustomerDemo/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerCustomerDemoService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerCustomerDemo/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.CustomerCustomerDemoService = $Cengaver_Northwind_CustomerCustomerDemoService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerDemographicDialog
	var $Cengaver_Northwind_CustomerDemographicDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_CustomerDemographicDialog.__typeName = 'Cengaver.Northwind.CustomerDemographicDialog';
	global.Cengaver.Northwind.CustomerDemographicDialog = $Cengaver_Northwind_CustomerDemographicDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerDemographicForm
	var $Cengaver_Northwind_CustomerDemographicForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_CustomerDemographicForm.__typeName = 'Cengaver.Northwind.CustomerDemographicForm';
	global.Cengaver.Northwind.CustomerDemographicForm = $Cengaver_Northwind_CustomerDemographicForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerDemographicGrid
	var $Cengaver_Northwind_CustomerDemographicGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_CustomerDemographicGrid.__typeName = 'Cengaver.Northwind.CustomerDemographicGrid';
	global.Cengaver.Northwind.CustomerDemographicGrid = $Cengaver_Northwind_CustomerDemographicGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerDemographicService
	var $Cengaver_Northwind_CustomerDemographicService = function() {
	};
	$Cengaver_Northwind_CustomerDemographicService.__typeName = 'Cengaver.Northwind.CustomerDemographicService';
	$Cengaver_Northwind_CustomerDemographicService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerDemographic/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerDemographicService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerDemographic/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerDemographicService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerDemographic/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerDemographicService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerDemographic/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerDemographicService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/CustomerDemographic/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.CustomerDemographicService = $Cengaver_Northwind_CustomerDemographicService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerDialog
	var $Cengaver_Northwind_CustomerDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_CustomerDialog.__typeName = 'Cengaver.Northwind.CustomerDialog';
	global.Cengaver.Northwind.CustomerDialog = $Cengaver_Northwind_CustomerDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerForm
	var $Cengaver_Northwind_CustomerForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_CustomerForm.__typeName = 'Cengaver.Northwind.CustomerForm';
	global.Cengaver.Northwind.CustomerForm = $Cengaver_Northwind_CustomerForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerGrid
	var $Cengaver_Northwind_CustomerGrid = function(container) {
		this.$country = null;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_CustomerGrid.__typeName = 'Cengaver.Northwind.CustomerGrid';
	global.Cengaver.Northwind.CustomerGrid = $Cengaver_Northwind_CustomerGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.CustomerService
	var $Cengaver_Northwind_CustomerService = function() {
	};
	$Cengaver_Northwind_CustomerService.__typeName = 'Cengaver.Northwind.CustomerService';
	$Cengaver_Northwind_CustomerService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Customer/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Customer/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Customer/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Customer/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_CustomerService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Customer/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.CustomerService = $Cengaver_Northwind_CustomerService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeDialog
	var $Cengaver_Northwind_EmployeeDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_EmployeeDialog.__typeName = 'Cengaver.Northwind.EmployeeDialog';
	global.Cengaver.Northwind.EmployeeDialog = $Cengaver_Northwind_EmployeeDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeForm
	var $Cengaver_Northwind_EmployeeForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_EmployeeForm.__typeName = 'Cengaver.Northwind.EmployeeForm';
	global.Cengaver.Northwind.EmployeeForm = $Cengaver_Northwind_EmployeeForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeGrid
	var $Cengaver_Northwind_EmployeeGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_EmployeeGrid.__typeName = 'Cengaver.Northwind.EmployeeGrid';
	global.Cengaver.Northwind.EmployeeGrid = $Cengaver_Northwind_EmployeeGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeService
	var $Cengaver_Northwind_EmployeeService = function() {
	};
	$Cengaver_Northwind_EmployeeService.__typeName = 'Cengaver.Northwind.EmployeeService';
	$Cengaver_Northwind_EmployeeService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Employee/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Employee/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Employee/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Employee/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Employee/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.EmployeeService = $Cengaver_Northwind_EmployeeService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeTerritoryDialog
	var $Cengaver_Northwind_EmployeeTerritoryDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_EmployeeTerritoryDialog.__typeName = 'Cengaver.Northwind.EmployeeTerritoryDialog';
	global.Cengaver.Northwind.EmployeeTerritoryDialog = $Cengaver_Northwind_EmployeeTerritoryDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeTerritoryForm
	var $Cengaver_Northwind_EmployeeTerritoryForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_EmployeeTerritoryForm.__typeName = 'Cengaver.Northwind.EmployeeTerritoryForm';
	global.Cengaver.Northwind.EmployeeTerritoryForm = $Cengaver_Northwind_EmployeeTerritoryForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeTerritoryGrid
	var $Cengaver_Northwind_EmployeeTerritoryGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_EmployeeTerritoryGrid.__typeName = 'Cengaver.Northwind.EmployeeTerritoryGrid';
	global.Cengaver.Northwind.EmployeeTerritoryGrid = $Cengaver_Northwind_EmployeeTerritoryGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.EmployeeTerritoryService
	var $Cengaver_Northwind_EmployeeTerritoryService = function() {
	};
	$Cengaver_Northwind_EmployeeTerritoryService.__typeName = 'Cengaver.Northwind.EmployeeTerritoryService';
	$Cengaver_Northwind_EmployeeTerritoryService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/EmployeeTerritory/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeTerritoryService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/EmployeeTerritory/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeTerritoryService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/EmployeeTerritory/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeTerritoryService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/EmployeeTerritory/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_EmployeeTerritoryService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/EmployeeTerritory/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.EmployeeTerritoryService = $Cengaver_Northwind_EmployeeTerritoryService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderDetailDialog
	var $Cengaver_Northwind_OrderDetailDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_OrderDetailDialog.__typeName = 'Cengaver.Northwind.OrderDetailDialog';
	global.Cengaver.Northwind.OrderDetailDialog = $Cengaver_Northwind_OrderDetailDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderDetailForm
	var $Cengaver_Northwind_OrderDetailForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_OrderDetailForm.__typeName = 'Cengaver.Northwind.OrderDetailForm';
	global.Cengaver.Northwind.OrderDetailForm = $Cengaver_Northwind_OrderDetailForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderDetailGrid
	var $Cengaver_Northwind_OrderDetailGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_OrderDetailGrid.__typeName = 'Cengaver.Northwind.OrderDetailGrid';
	global.Cengaver.Northwind.OrderDetailGrid = $Cengaver_Northwind_OrderDetailGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderDetailService
	var $Cengaver_Northwind_OrderDetailService = function() {
	};
	$Cengaver_Northwind_OrderDetailService.__typeName = 'Cengaver.Northwind.OrderDetailService';
	$Cengaver_Northwind_OrderDetailService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/OrderDetail/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderDetailService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/OrderDetail/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderDetailService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/OrderDetail/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderDetailService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/OrderDetail/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderDetailService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/OrderDetail/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.OrderDetailService = $Cengaver_Northwind_OrderDetailService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderDialog
	var $Cengaver_Northwind_OrderDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_OrderDialog.__typeName = 'Cengaver.Northwind.OrderDialog';
	global.Cengaver.Northwind.OrderDialog = $Cengaver_Northwind_OrderDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderForm
	var $Cengaver_Northwind_OrderForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_OrderForm.__typeName = 'Cengaver.Northwind.OrderForm';
	global.Cengaver.Northwind.OrderForm = $Cengaver_Northwind_OrderForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderGrid
	var $Cengaver_Northwind_OrderGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_OrderGrid.__typeName = 'Cengaver.Northwind.OrderGrid';
	global.Cengaver.Northwind.OrderGrid = $Cengaver_Northwind_OrderGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.OrderService
	var $Cengaver_Northwind_OrderService = function() {
	};
	$Cengaver_Northwind_OrderService.__typeName = 'Cengaver.Northwind.OrderService';
	$Cengaver_Northwind_OrderService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Order/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Order/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Order/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Order/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_OrderService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Order/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.OrderService = $Cengaver_Northwind_OrderService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.PhoneEditor
	var $Cengaver_Northwind_PhoneEditor = function(input) {
		this.$5$MultipleField = false;
		Serenity.StringEditor.call(this, input);
		Serenity.VX.addValidationRule(this, this.uniqueName, ss.mkdel(this, function(e) {
			var value = Q.trimToNull(this.get_value());
			if (ss.isNullOrUndefined(value)) {
				return null;
			}
			return $Cengaver_Northwind_PhoneEditor.$validate(value, this.get_multiple());
		}));
		input.bind('change', ss.mkdel(this, function(e1) {
			if (!Serenity.WX.hasOriginalEvent(e1)) {
				return;
			}
			this.formatValue();
		}));
		input.bind('blur', ss.mkdel(this, function(e2) {
			if (this.element.hasClass('valid')) {
				this.formatValue();
			}
		}));
	};
	$Cengaver_Northwind_PhoneEditor.__typeName = 'Cengaver.Northwind.PhoneEditor';
	$Cengaver_Northwind_PhoneEditor.$validate = function(phone, isMultiple) {
		var valid = (isMultiple ? $Cengaver_Northwind_PhoneEditor.$isValidMulti(phone, $Cengaver_Northwind_PhoneEditor.$isValidPhone) : $Cengaver_Northwind_PhoneEditor.$isValidPhone(phone));
		if (valid) {
			return null;
		}
		return Q.text((isMultiple ? 'Validation.NorthwindPhoneMultiple' : 'Validation.NorthwindPhone'));
	};
	$Cengaver_Northwind_PhoneEditor.$isValidPhone = function(phone) {
		if (Q.isEmptyOrNull(phone)) {
			return false;
		}
		phone = ss.replaceAllString(ss.replaceAllString(phone, ' ', ''), '-', '');
		if (phone.length < 10) {
			return false;
		}
		if (ss.startsWithString(phone, '0')) {
			phone = phone.substring(1);
		}
		if (ss.startsWithString(phone, '(') && phone.charCodeAt(4) === 41) {
			phone = phone.substr(1, 3) + phone.substring(5);
		}
		if (phone.length !== 10) {
			return false;
		}
		if (ss.startsWithString(phone, '0')) {
			return false;
		}
		for (var i = 0; i < phone.length; i++) {
			var c = phone.charCodeAt(i);
			if (c < 48 || c > 57) {
				return false;
			}
		}
		return true;
	};
	$Cengaver_Northwind_PhoneEditor.$formatPhone = function(phone) {
		if (!$Cengaver_Northwind_PhoneEditor.$isValidPhone(phone)) {
			return phone;
		}
		phone = ss.replaceAllString(ss.replaceAllString(ss.replaceAllString(ss.replaceAllString(phone, ' ', ''), '-', ''), '(', ''), ')', '');
		if (ss.startsWithString(phone, '0')) {
			phone = phone.substring(1);
		}
		phone = '(' + phone.substr(0, 3) + ') ' + phone.substr(3, 3) + '-' + phone.substr(6, 2) + phone.substr(8, 2);
		return phone;
	};
	$Cengaver_Northwind_PhoneEditor.$formatMulti = function(phone, format) {
		var phones = ss.replaceAllString(phone, String.fromCharCode(59), String.fromCharCode(44)).split(String.fromCharCode(44));
		var result = '';
		for (var $t1 = 0; $t1 < phones.length; $t1++) {
			var x = phones[$t1];
			var s = Q.trimToNull(x);
			if (ss.isNullOrUndefined(s)) {
				continue;
			}
			if (result.length > 0) {
				result += ', ';
			}
			result += format(s);
		}
		return result;
	};
	$Cengaver_Northwind_PhoneEditor.$isValidMulti = function(phone, check) {
		if (Q.isEmptyOrNull(phone)) {
			return false;
		}
		var phones = ss.replaceAllString(phone, String.fromCharCode(59), String.fromCharCode(44)).split(String.fromCharCode(44));
		var anyValid = false;
		for (var $t1 = 0; $t1 < phones.length; $t1++) {
			var x = phones[$t1];
			var s = Q.trimToNull(x);
			if (ss.isNullOrUndefined(s)) {
				continue;
			}
			if (!check(s)) {
				return false;
			}
			anyValid = true;
		}
		if (!anyValid) {
			return false;
		}
		return true;
	};
	global.Cengaver.Northwind.PhoneEditor = $Cengaver_Northwind_PhoneEditor;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ProductDialog
	var $Cengaver_Northwind_ProductDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_ProductDialog.__typeName = 'Cengaver.Northwind.ProductDialog';
	global.Cengaver.Northwind.ProductDialog = $Cengaver_Northwind_ProductDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ProductForm
	var $Cengaver_Northwind_ProductForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_ProductForm.__typeName = 'Cengaver.Northwind.ProductForm';
	global.Cengaver.Northwind.ProductForm = $Cengaver_Northwind_ProductForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ProductGrid
	var $Cengaver_Northwind_ProductGrid = function(container) {
		this.$supplier = null;
		this.$category = null;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_ProductGrid.__typeName = 'Cengaver.Northwind.ProductGrid';
	global.Cengaver.Northwind.ProductGrid = $Cengaver_Northwind_ProductGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ProductService
	var $Cengaver_Northwind_ProductService = function() {
	};
	$Cengaver_Northwind_ProductService.__typeName = 'Cengaver.Northwind.ProductService';
	$Cengaver_Northwind_ProductService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Product/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_ProductService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Product/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_ProductService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Product/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_ProductService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Product/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_ProductService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Product/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.ProductService = $Cengaver_Northwind_ProductService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.RegionDialog
	var $Cengaver_Northwind_RegionDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_RegionDialog.__typeName = 'Cengaver.Northwind.RegionDialog';
	global.Cengaver.Northwind.RegionDialog = $Cengaver_Northwind_RegionDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.RegionForm
	var $Cengaver_Northwind_RegionForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_RegionForm.__typeName = 'Cengaver.Northwind.RegionForm';
	global.Cengaver.Northwind.RegionForm = $Cengaver_Northwind_RegionForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.RegionGrid
	var $Cengaver_Northwind_RegionGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_RegionGrid.__typeName = 'Cengaver.Northwind.RegionGrid';
	global.Cengaver.Northwind.RegionGrid = $Cengaver_Northwind_RegionGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.RegionService
	var $Cengaver_Northwind_RegionService = function() {
	};
	$Cengaver_Northwind_RegionService.__typeName = 'Cengaver.Northwind.RegionService';
	$Cengaver_Northwind_RegionService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Region/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_RegionService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Region/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_RegionService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Region/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_RegionService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Region/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_RegionService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Region/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.RegionService = $Cengaver_Northwind_RegionService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ShipperDialog
	var $Cengaver_Northwind_ShipperDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_ShipperDialog.__typeName = 'Cengaver.Northwind.ShipperDialog';
	global.Cengaver.Northwind.ShipperDialog = $Cengaver_Northwind_ShipperDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ShipperForm
	var $Cengaver_Northwind_ShipperForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_ShipperForm.__typeName = 'Cengaver.Northwind.ShipperForm';
	global.Cengaver.Northwind.ShipperForm = $Cengaver_Northwind_ShipperForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ShipperGrid
	var $Cengaver_Northwind_ShipperGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_ShipperGrid.__typeName = 'Cengaver.Northwind.ShipperGrid';
	global.Cengaver.Northwind.ShipperGrid = $Cengaver_Northwind_ShipperGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.ShipperService
	var $Cengaver_Northwind_ShipperService = function() {
	};
	$Cengaver_Northwind_ShipperService.__typeName = 'Cengaver.Northwind.ShipperService';
	$Cengaver_Northwind_ShipperService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Shipper/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_ShipperService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Shipper/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_ShipperService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Shipper/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_ShipperService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Shipper/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_ShipperService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Shipper/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.ShipperService = $Cengaver_Northwind_ShipperService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.SupplierDialog
	var $Cengaver_Northwind_SupplierDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_SupplierDialog.__typeName = 'Cengaver.Northwind.SupplierDialog';
	global.Cengaver.Northwind.SupplierDialog = $Cengaver_Northwind_SupplierDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.SupplierForm
	var $Cengaver_Northwind_SupplierForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_SupplierForm.__typeName = 'Cengaver.Northwind.SupplierForm';
	global.Cengaver.Northwind.SupplierForm = $Cengaver_Northwind_SupplierForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.SupplierGrid
	var $Cengaver_Northwind_SupplierGrid = function(container) {
		this.$country = null;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_SupplierGrid.__typeName = 'Cengaver.Northwind.SupplierGrid';
	global.Cengaver.Northwind.SupplierGrid = $Cengaver_Northwind_SupplierGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.SupplierService
	var $Cengaver_Northwind_SupplierService = function() {
	};
	$Cengaver_Northwind_SupplierService.__typeName = 'Cengaver.Northwind.SupplierService';
	$Cengaver_Northwind_SupplierService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Supplier/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_SupplierService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Supplier/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_SupplierService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Supplier/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_SupplierService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Supplier/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_SupplierService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Supplier/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.SupplierService = $Cengaver_Northwind_SupplierService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.TerritoryDialog
	var $Cengaver_Northwind_TerritoryDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_Northwind_TerritoryDialog.__typeName = 'Cengaver.Northwind.TerritoryDialog';
	global.Cengaver.Northwind.TerritoryDialog = $Cengaver_Northwind_TerritoryDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.TerritoryForm
	var $Cengaver_Northwind_TerritoryForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_Northwind_TerritoryForm.__typeName = 'Cengaver.Northwind.TerritoryForm';
	global.Cengaver.Northwind.TerritoryForm = $Cengaver_Northwind_TerritoryForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.TerritoryGrid
	var $Cengaver_Northwind_TerritoryGrid = function(container) {
		this.$region = null;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_Northwind_TerritoryGrid.__typeName = 'Cengaver.Northwind.TerritoryGrid';
	global.Cengaver.Northwind.TerritoryGrid = $Cengaver_Northwind_TerritoryGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.Northwind.TerritoryService
	var $Cengaver_Northwind_TerritoryService = function() {
	};
	$Cengaver_Northwind_TerritoryService.__typeName = 'Cengaver.Northwind.TerritoryService';
	$Cengaver_Northwind_TerritoryService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Territory/Create', request, onSuccess, options);
	};
	$Cengaver_Northwind_TerritoryService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Territory/Update', request, onSuccess, options);
	};
	$Cengaver_Northwind_TerritoryService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Territory/Delete', request, onSuccess, options);
	};
	$Cengaver_Northwind_TerritoryService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Territory/Retrieve', request, onSuccess, options);
	};
	$Cengaver_Northwind_TerritoryService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('Northwind/Territory/List', request, onSuccess, options);
	};
	global.Cengaver.Northwind.TerritoryService = $Cengaver_Northwind_TerritoryService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CityDialog
	var $Cengaver_TvHastanesi_CityDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_TvHastanesi_CityDialog.__typeName = 'Cengaver.TvHastanesi.CityDialog';
	global.Cengaver.TvHastanesi.CityDialog = $Cengaver_TvHastanesi_CityDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CityForm
	var $Cengaver_TvHastanesi_CityForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_TvHastanesi_CityForm.__typeName = 'Cengaver.TvHastanesi.CityForm';
	global.Cengaver.TvHastanesi.CityForm = $Cengaver_TvHastanesi_CityForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CityGrid
	var $Cengaver_TvHastanesi_CityGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_TvHastanesi_CityGrid.__typeName = 'Cengaver.TvHastanesi.CityGrid';
	global.Cengaver.TvHastanesi.CityGrid = $Cengaver_TvHastanesi_CityGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CityService
	var $Cengaver_TvHastanesi_CityService = function() {
	};
	$Cengaver_TvHastanesi_CityService.__typeName = 'Cengaver.TvHastanesi.CityService';
	$Cengaver_TvHastanesi_CityService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/City/Create', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CityService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/City/Update', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CityService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/City/Delete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CityService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/City/Retrieve', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CityService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/City/List', request, onSuccess, options);
	};
	global.Cengaver.TvHastanesi.CityService = $Cengaver_TvHastanesi_CityService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CountyDialog
	var $Cengaver_TvHastanesi_CountyDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_TvHastanesi_CountyDialog.__typeName = 'Cengaver.TvHastanesi.CountyDialog';
	global.Cengaver.TvHastanesi.CountyDialog = $Cengaver_TvHastanesi_CountyDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CountyEditor
	var $Cengaver_TvHastanesi_CountyEditor = function(hidden) {
		this.$cityEditorID = null;
		this.$cityID = null;
		ss.makeGenericType(Serenity.LookupEditorBase$1, [Object]).call(this, hidden);
	};
	$Cengaver_TvHastanesi_CountyEditor.__typeName = 'Cengaver.TvHastanesi.CountyEditor';
	global.Cengaver.TvHastanesi.CountyEditor = $Cengaver_TvHastanesi_CountyEditor;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CountyForm
	var $Cengaver_TvHastanesi_CountyForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_TvHastanesi_CountyForm.__typeName = 'Cengaver.TvHastanesi.CountyForm';
	global.Cengaver.TvHastanesi.CountyForm = $Cengaver_TvHastanesi_CountyForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CountyGrid
	var $Cengaver_TvHastanesi_CountyGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_TvHastanesi_CountyGrid.__typeName = 'Cengaver.TvHastanesi.CountyGrid';
	global.Cengaver.TvHastanesi.CountyGrid = $Cengaver_TvHastanesi_CountyGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CountyService
	var $Cengaver_TvHastanesi_CountyService = function() {
	};
	$Cengaver_TvHastanesi_CountyService.__typeName = 'Cengaver.TvHastanesi.CountyService';
	$Cengaver_TvHastanesi_CountyService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/County/Create', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CountyService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/County/Update', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CountyService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/County/Delete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CountyService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/County/Retrieve', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CountyService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/County/List', request, onSuccess, options);
	};
	global.Cengaver.TvHastanesi.CountyService = $Cengaver_TvHastanesi_CountyService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CustomerDialog
	var $Cengaver_TvHastanesi_CustomerDialog = function(op) {
		this.$form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.$form = new $Cengaver_TvHastanesi_CustomerForm(this.get_idPrefix());
		Serenity.WX.change(this.$form.get_emailAddress(), function(e) {
			//Q.Alert("email address changed" + form.EmailAddress.Value);
		});
		//jQueryEventHandler changeSiteId = delegate(jQueryEvent e)
		//{
		//    new UserTypeEditor(this.ById("UserTypeId"), new UserTypeEditorOptions() { SiteId = int.Parse(B2CSiteSettingEditor.From(this.ById("SiteId")).Value.ToString()) });
		//};
		//this.ById("SiteId").bind("change", changeSiteId).bind("updateDependents", changeSiteId);
		//new CustomerEditor(this.ById("UpdateUserId"));
	};
	$Cengaver_TvHastanesi_CustomerDialog.__typeName = 'Cengaver.TvHastanesi.CustomerDialog';
	global.Cengaver.TvHastanesi.CustomerDialog = $Cengaver_TvHastanesi_CustomerDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CustomerEditor
	var $Cengaver_TvHastanesi_CustomerEditor = function(select) {
		ss.makeGenericType(Serenity.LookupEditorBase$2, [Object, Object]).call(this, select, new Object());
	};
	$Cengaver_TvHastanesi_CustomerEditor.__typeName = 'Cengaver.TvHastanesi.CustomerEditor';
	global.Cengaver.TvHastanesi.CustomerEditor = $Cengaver_TvHastanesi_CustomerEditor;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CustomerForm
	var $Cengaver_TvHastanesi_CustomerForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_TvHastanesi_CustomerForm.__typeName = 'Cengaver.TvHastanesi.CustomerForm';
	global.Cengaver.TvHastanesi.CustomerForm = $Cengaver_TvHastanesi_CustomerForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CustomerGrid
	var $Cengaver_TvHastanesi_CustomerGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_TvHastanesi_CustomerGrid.__typeName = 'Cengaver.TvHastanesi.CustomerGrid';
	global.Cengaver.TvHastanesi.CustomerGrid = $Cengaver_TvHastanesi_CustomerGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.CustomerService
	var $Cengaver_TvHastanesi_CustomerService = function() {
	};
	$Cengaver_TvHastanesi_CustomerService.__typeName = 'Cengaver.TvHastanesi.CustomerService';
	$Cengaver_TvHastanesi_CustomerService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Customer/Create', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CustomerService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Customer/Update', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CustomerService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Customer/Delete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CustomerService.undelete = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Customer/Undelete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CustomerService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Customer/Retrieve', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_CustomerService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Customer/List', request, onSuccess, options);
	};
	global.Cengaver.TvHastanesi.CustomerService = $Cengaver_TvHastanesi_CustomerService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.EditorItem
	var $Cengaver_TvHastanesi_EditorItem = function() {
		this.id = 0;
		this.text = null;
		this.disabled = false;
	};
	$Cengaver_TvHastanesi_EditorItem.__typeName = 'Cengaver.TvHastanesi.EditorItem';
	global.Cengaver.TvHastanesi.EditorItem = $Cengaver_TvHastanesi_EditorItem;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.MenuDialog
	var $Cengaver_TvHastanesi_MenuDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_TvHastanesi_MenuDialog.__typeName = 'Cengaver.TvHastanesi.MenuDialog';
	global.Cengaver.TvHastanesi.MenuDialog = $Cengaver_TvHastanesi_MenuDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.MenuForm
	var $Cengaver_TvHastanesi_MenuForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_TvHastanesi_MenuForm.__typeName = 'Cengaver.TvHastanesi.MenuForm';
	global.Cengaver.TvHastanesi.MenuForm = $Cengaver_TvHastanesi_MenuForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.MenuGrid
	var $Cengaver_TvHastanesi_MenuGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_TvHastanesi_MenuGrid.__typeName = 'Cengaver.TvHastanesi.MenuGrid';
	global.Cengaver.TvHastanesi.MenuGrid = $Cengaver_TvHastanesi_MenuGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.MenuService
	var $Cengaver_TvHastanesi_MenuService = function() {
	};
	$Cengaver_TvHastanesi_MenuService.__typeName = 'Cengaver.TvHastanesi.MenuService';
	$Cengaver_TvHastanesi_MenuService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Menu/Create', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_MenuService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Menu/Update', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_MenuService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Menu/Delete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_MenuService.undelete = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Menu/Undelete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_MenuService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Menu/Retrieve', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_MenuService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Menu/List', request, onSuccess, options);
	};
	global.Cengaver.TvHastanesi.MenuService = $Cengaver_TvHastanesi_MenuService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.ServiceTicketDialog
	var $Cengaver_TvHastanesi_ServiceTicketDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_TvHastanesi_ServiceTicketDialog.__typeName = 'Cengaver.TvHastanesi.ServiceTicketDialog';
	global.Cengaver.TvHastanesi.ServiceTicketDialog = $Cengaver_TvHastanesi_ServiceTicketDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.ServiceTicketForm
	var $Cengaver_TvHastanesi_ServiceTicketForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_TvHastanesi_ServiceTicketForm.__typeName = 'Cengaver.TvHastanesi.ServiceTicketForm';
	global.Cengaver.TvHastanesi.ServiceTicketForm = $Cengaver_TvHastanesi_ServiceTicketForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.ServiceTicketGrid
	var $Cengaver_TvHastanesi_ServiceTicketGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_TvHastanesi_ServiceTicketGrid.__typeName = 'Cengaver.TvHastanesi.ServiceTicketGrid';
	global.Cengaver.TvHastanesi.ServiceTicketGrid = $Cengaver_TvHastanesi_ServiceTicketGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.ServiceTicketService
	var $Cengaver_TvHastanesi_ServiceTicketService = function() {
	};
	$Cengaver_TvHastanesi_ServiceTicketService.__typeName = 'Cengaver.TvHastanesi.ServiceTicketService';
	$Cengaver_TvHastanesi_ServiceTicketService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/ServiceTicket/Create', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_ServiceTicketService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/ServiceTicket/Update', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_ServiceTicketService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/ServiceTicket/Delete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_ServiceTicketService.undelete = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/ServiceTicket/Undelete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_ServiceTicketService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/ServiceTicket/Retrieve', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_ServiceTicketService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/ServiceTicket/List', request, onSuccess, options);
	};
	global.Cengaver.TvHastanesi.ServiceTicketService = $Cengaver_TvHastanesi_ServiceTicketService;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.UnitDialog
	var $Cengaver_TvHastanesi_UnitDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$Cengaver_TvHastanesi_UnitDialog.__typeName = 'Cengaver.TvHastanesi.UnitDialog';
	global.Cengaver.TvHastanesi.UnitDialog = $Cengaver_TvHastanesi_UnitDialog;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.UnitForm
	var $Cengaver_TvHastanesi_UnitForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$Cengaver_TvHastanesi_UnitForm.__typeName = 'Cengaver.TvHastanesi.UnitForm';
	global.Cengaver.TvHastanesi.UnitForm = $Cengaver_TvHastanesi_UnitForm;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.UnitGrid
	var $Cengaver_TvHastanesi_UnitGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$Cengaver_TvHastanesi_UnitGrid.__typeName = 'Cengaver.TvHastanesi.UnitGrid';
	global.Cengaver.TvHastanesi.UnitGrid = $Cengaver_TvHastanesi_UnitGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Cengaver.TvHastanesi.UnitService
	var $Cengaver_TvHastanesi_UnitService = function() {
	};
	$Cengaver_TvHastanesi_UnitService.__typeName = 'Cengaver.TvHastanesi.UnitService';
	$Cengaver_TvHastanesi_UnitService.create = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Unit/Create', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_UnitService.update = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Unit/Update', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_UnitService.delete$1 = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Unit/Delete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_UnitService.undelete = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Unit/Undelete', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_UnitService.retrieve = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Unit/Retrieve', request, onSuccess, options);
	};
	$Cengaver_TvHastanesi_UnitService.list = function(request, onSuccess, options) {
		return Q.serviceRequest('TvHastanesi/Unit/List', request, onSuccess, options);
	};
	global.Cengaver.TvHastanesi.UnitService = $Cengaver_TvHastanesi_UnitService;
	ss.initClass($Cengaver_ScriptInitialization, $asm, {});
	ss.initClass($Cengaver_Administration_LanguageDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Administration_LanguageForm, $asm, {
		get_languageId: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LanguageId');
		},
		get_languageName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LanguageName');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Administration_LanguageGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Administration_LanguageService, $asm, {});
	ss.initClass($Cengaver_Administration_PermissionCheckEditor, $asm, {
		getButtons: function() {
			return [];
		},
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.get_element(), ss.mkdel(this, function(field, text) {
				this.$containsText = Q.trimToNull(text);
				this.view.setItems(this.view.getItems(), true);
			}), null);
		},
		onViewFilter: function(item) {
			if (!ss.makeGenericType(Serenity.CheckTreeEditor$2, [Object, Object]).prototype.onViewFilter.call(this, item)) {
				return false;
			}
			var contains = Select2.util.stripDiacritics(ss.coalesce(this.$containsText, '')).toUpperCase();
			if (Q.isEmptyOrNull(contains)) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.text, '')).toUpperCase().indexOf(contains) !== -1) {
				return true;
			}
			return false;
		},
		getItems: function() {
			var list = [];
			var permissions = Q.getRemoteData('Administration.PermissionKeys').Entities;
			var permissionTitles = {};
			for (var i = 0; i < permissions.length; i++) {
				var p = permissions[i];
				permissionTitles[p] = ss.coalesce(Q.tryGetText('Permission.' + p), p);
			}
			permissions.sort(function(x, y) {
				return Q$Externals.turkishLocaleCompare(permissionTitles[x], permissionTitles[y]);
			});
			for (var $t1 = 0; $t1 < permissions.length; $t1++) {
				var permission = permissions[$t1];
				list.push({ id: permission, text: permissionTitles[permission] });
			}
			return list;
		}
	}, ss.makeGenericType(Serenity.CheckTreeEditor$1, [Object]), [Serenity.IDataGrid, Serenity.IGetEditValue, Serenity.ISetEditValue]);
	ss.initClass($Cengaver_Administration_PermissionModuleEditor, $asm, {}, ss.makeGenericType(Serenity.Select2Editor$2, [Object, String]), [Serenity.IStringValue]);
	ss.initClass($Cengaver_Administration_RoleCheckEditor, $asm, {
		getButtons: function() {
			return [];
		},
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.get_element(), ss.mkdel(this, function(field, text) {
				this.$containsText = Q.trimToNull(text);
				this.view.setItems(this.view.getItems(), true);
			}), null);
		},
		onViewFilter: function(item) {
			if (!ss.makeGenericType(Serenity.CheckTreeEditor$2, [Object, Object]).prototype.onViewFilter.call(this, item)) {
				return false;
			}
			var contains = Select2.util.stripDiacritics(ss.coalesce(this.$containsText, '')).toUpperCase();
			if (Q.isEmptyOrNull(contains)) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.text, '')).toUpperCase().indexOf(contains) !== -1) {
				return true;
			}
			return false;
		},
		getItems: function() {
			var list = [];
			var roles = Q.getLookup('Administration.Role').get_items();
			for (var $t1 = 0; $t1 < roles.length; $t1++) {
				var role = roles[$t1];
				list.push({ id: role.RoleId.toString(), text: role.RoleName });
			}
			return list;
		}
	}, ss.makeGenericType(Serenity.CheckTreeEditor$1, [Object]), [Serenity.IDataGrid, Serenity.IGetEditValue, Serenity.ISetEditValue]);
	ss.initClass($Cengaver_Administration_RoleDialog, $asm, {
		getToolbarButtons: function() {
			var buttons = ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.getToolbarButtons.call(this);
			buttons.push({ title: Q.text('Site.RolePermissionDialog.EditButton'), cssClass: 'lock-button', onClick: ss.mkdel(this, function() {
				(new $Cengaver_Administration_RolePermissionDialog({ roleID: ss.unbox(this.get_entity().RoleId), title: this.get_entity().RoleName })).dialogOpen();
			}) });
			return buttons;
		},
		updateInterface: function() {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.updateInterface.call(this);
			this.toolbar.findButton('lock-button').toggleClass('disabled', this.get_isNewOrDeleted());
		}
	}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Administration_RoleForm, $asm, {
		get_roleName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'RoleName');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Administration_RoleGrid, $asm, {
		getDefaultSortBy: function() {
			var $t1 = [];
			$t1.push('RoleName');
			return $t1;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Administration_RolePermissionDialog, $asm, {
		getDialogOptions: function() {
			var opt = ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.getDialogOptions.call(this);
			var $t1 = [];
			$t1.push({ text: Q.text('Dialogs.OkButton'), click: ss.mkdel(this, function() {
				$Cengaver_Administration_RolePermissionService.update({ RoleID: this.options.roleID, Permissions: this.$permissions.get_value(), Module: null, Submodule: null }, ss.mkdel(this, function(response) {
					this.dialogClose();
					window.setTimeout(function() {
						Q.notifySuccess(Q.text('Site.RolePermissionDialog.SaveSuccess'));
					}, 0);
				}), null);
			}) });
			$t1.push({ text: Q.text('Dialogs.CancelButton'), click: ss.mkdel(this, this.dialogClose) });
			opt.buttons = $t1;
			opt.title = ss.formatString(Q.text('Site.RolePermissionDialog.DialogTitle'), this.options.title);
			return opt;
		},
		getTemplate: function() {
			return "<div id='~_Permissions'></div>";
		}
	}, ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]), [Serenity.IDialog]);
	ss.initClass($Cengaver_Administration_RolePermissionService, $asm, {});
	ss.initClass($Cengaver_Administration_RoleService, $asm, {});
	ss.initClass($Cengaver_Administration_TranslationGrid, $asm, {
		onClick: function(e, row, cell) {
			ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onClick.call(this, e, row, cell);
			if (e.isDefaultPrevented()) {
				return;
			}
			if ($(e.target).hasClass('source-text')) {
				e.preventDefault();
				var item = this.view.rows[row];
				var done = ss.mkdel(this, function() {
					item.CustomText = item.SourceText;
					this.view.updateItem(item.Key, item);
					this.$hasChanges = true;
				});
				if (Q.isTrimmedEmpty(item.CustomText) || ss.referenceEquals(Q.trimToEmpty(item.CustomText), Q.trimToEmpty(item.SourceText))) {
					done();
					return;
				}
				Q.confirm(Q.text('Db.Administration.Translation.OverrideConfirmation'), done);
			}
			if ($(e.target).hasClass('target-text')) {
				e.preventDefault();
				var item1 = this.view.rows[row];
				var done1 = ss.mkdel(this, function() {
					item1.CustomText = item1.TargetText;
					this.view.updateItem(item1.Key, item1);
					this.$hasChanges = true;
				});
				if (Q.isTrimmedEmpty(item1.CustomText) || ss.referenceEquals(Q.trimToEmpty(item1.CustomText), Q.trimToEmpty(item1.TargetText))) {
					done1();
					return;
				}
				Q.confirm(Q.text('Db.Administration.Translation.OverrideConfirmation'), done1);
			}
		},
		getColumnsAsync: function() {
			var columns = [];
			columns.push({ field: 'Key', width: 300, sortable: false });
			columns.push({
				field: 'SourceText',
				width: 300,
				sortable: false,
				format: function(ctx) {
					return Q.outerHtml($('<a/>').addClass('source-text').text(ss.coalesce(ss.cast(ctx.value, String), '')));
				}
			});
			columns.push({
				field: 'CustomText',
				width: 300,
				sortable: false,
				format: function(ctx1) {
					return Q.outerHtml($('<input/>').addClass('custom-text').attr('value', ss.cast(ctx1.value, String)).attr('type', 'text').attr('data-key', ss.cast(ctx1.item.Key, String)));
				}
			});
			columns.push({
				field: 'TargetText',
				width: 300,
				sortable: false,
				format: function(ctx2) {
					return Q.outerHtml($('<a/>').addClass('target-text').text(ss.coalesce(ss.cast(ctx2.value, String), '')));
				}
			});
			return RSVP.resolve(columns);
		},
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Administration.Translation.SourceLanguage') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Administration.Language';
			this.$sourceLanguage = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.changeSelect2(this.$sourceLanguage, ss.mkdel(this, function(e1) {
				if (this.$hasChanges) {
					this.saveChanges(this.$targetLanguageKey).then(ss.mkdel(this, this.refresh), null);
				}
				else {
					this.refresh();
				}
			}));
			var $t4 = ss.mkdel(this, function(e2) {
				e2.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Administration.Translation.TargetLanguage') + ' ---');
			});
			var $t3 = Serenity.LookupEditorOptions.$ctor();
			$t3.lookupKey = 'Administration.Language';
			this.$targetLanguage = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t4, $t3, null);
			Serenity.WX.changeSelect2(this.$targetLanguage, ss.mkdel(this, function(e3) {
				if (this.$hasChanges) {
					this.saveChanges(this.$targetLanguageKey).then(ss.mkdel(this, this.refresh), null);
				}
				else {
					this.refresh();
				}
			}));
		},
		saveChanges: function(language) {
			var translations = {};
			var $t1 = this.view.getItems();
			for (var $t2 = 0; $t2 < $t1.length; $t2++) {
				var item = $t1[$t2];
				translations[item.Key] = item.CustomText;
			}
			return RSVP.resolve($Cengaver_Administration_TranslationService.update({ TargetLanguageID: language, Translations: translations }, null, null)).then(ss.mkdel(this, function() {
				this.$hasChanges = false;
				Q.notifySuccess('User translations in "' + language + '" language are saved to "user.texts.' + language + '.json" ' + 'file under "~/script/site/texts/user/"');
			}), null);
		},
		onViewSubmit: function() {
			var request = this.view.params;
			request.SourceLanguageID = this.$sourceLanguage.get_value();
			this.$targetLanguageKey = ss.coalesce(this.$targetLanguage.get_value(), '');
			request.TargetLanguageID = this.$targetLanguageKey;
			this.$hasChanges = false;
			return ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this);
		},
		getButtons: function() {
			var $t1 = [];
			$t1.push({ title: 'Save Changes', onClick: ss.mkdel(this, function(e) {
				this.saveChanges(this.$targetLanguageKey).then(ss.mkdel(this, this.refresh), null);
			}), cssClass: 'apply-changes-button' });
			return $t1;
		},
		createQuickSearchInput: function() {
			Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.get_element(), ss.mkdel(this, function(field, searchText) {
				this.$searchText = searchText;
				this.view.setItems(this.view.getItems(), true);
			}), null);
		},
		onViewFilter: function(item) {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewFilter.call(this, item)) {
				return false;
			}
			if (Q.isEmptyOrNull(this.$searchText)) {
				return true;
			}
			var searching = Select2.util.stripDiacritics(this.$searchText).toLowerCase();
			if (Q.isEmptyOrNull(searching)) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.Key, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.SourceText, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.TargetText, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.CustomText, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			return false;
		},
		usePager: function() {
			return false;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Administration_TranslationService, $asm, {});
	ss.initClass($Cengaver_Administration_UserDialog, $asm, {
		getToolbarButtons: function() {
			var buttons = ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.getToolbarButtons.call(this);
			buttons.push({ title: Q.text('Site.UserDialog.EditRolesButton'), cssClass: 'users-button', onClick: ss.mkdel(this, function() {
				(new $Cengaver_Administration_UserRoleDialog({ userID: ss.unbox(this.get_entity().UserId), username: this.get_entity().Username })).dialogOpen();
			}) });
			buttons.push({ title: Q.text('Site.UserDialog.EditPermissionsButton'), cssClass: 'lock-button', onClick: ss.mkdel(this, function() {
				(new $Cengaver_Administration_UserPermissionDialog({ userID: ss.unbox(this.get_entity().UserId), username: this.get_entity().Username })).dialogOpen();
			}) });
			return buttons;
		},
		updateInterface: function() {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.updateInterface.call(this);
			this.toolbar.findButton('users-button').toggleClass('disabled', this.get_isNewOrDeleted());
			this.toolbar.findButton('lock-button').toggleClass('disabled', this.get_isNewOrDeleted());
		}
	}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($Cengaver_Administration_UserForm, $asm, {
		get_username: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Username');
		},
		get_displayName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'DisplayName');
		},
		get_email: function() {
			return this.byId(Serenity.EmailEditor).call(this, 'Email');
		},
		get_password: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'Password');
		},
		get_passwordConfirm: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'PasswordConfirm');
		},
		get_source: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Source');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Administration_UserGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'UserId', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'Username', width: 150, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'DisplayName', width: 150 });
			columns.push({ field: 'Email', width: 250 });
			columns.push({ field: 'Source', width: 100 });
			return columns;
		},
		getDefaultSortBy: function() {
			var $t1 = [];
			$t1.push('Username');
			return $t1;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Administration_UserPermissionDialog, $asm, {
		getDialogOptions: function() {
			var opt = ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.getDialogOptions.call(this);
			var $t1 = [];
			$t1.push({ text: Q.text('Dialogs.OkButton'), click: ss.mkdel(this, function() {
				$Cengaver_Administration_UserPermissionService.update({ UserID: this.options.userID, Permissions: this.$permissions.get_value(), Module: null, Submodule: null }, ss.mkdel(this, function(response) {
					this.dialogClose();
					window.setTimeout(function() {
						Q.notifySuccess(Q.text('Site.UserPermissionDialog.SaveSuccess'));
					}, 0);
				}), null);
			}) });
			$t1.push({ text: Q.text('Dialogs.CancelButton'), click: ss.mkdel(this, this.dialogClose) });
			opt.buttons = $t1;
			opt.title = ss.formatString(Q.text('Site.UserPermissionDialog.DialogTitle'), this.options.username);
			return opt;
		},
		getTemplate: function() {
			return "<div id='~_Permissions'></div>";
		}
	}, ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]), [Serenity.IDialog]);
	ss.initClass($Cengaver_Administration_UserPermissionService, $asm, {});
	ss.initClass($Cengaver_Administration_UserRoleDialog, $asm, {
		getDialogOptions: function() {
			var opt = ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.getDialogOptions.call(this);
			var $t1 = [];
			$t1.push({ text: Q.text('Dialogs.OkButton'), click: ss.mkdel(this, function() {
				$Cengaver_Administration_UserRoleService.update({ UserID: this.options.userID, Roles: Enumerable.from(this.$permissions.get_value()).select(function(x) {
					return parseInt(x, 10);
				}).toArray() }, ss.mkdel(this, function(response) {
					this.dialogClose();
					window.setTimeout(function() {
						Q.notifySuccess(Q.text('Site.UserRoleDialog.SaveSuccess'));
					}, 0);
				}), null);
			}) });
			$t1.push({ text: Q.text('Dialogs.CancelButton'), click: ss.mkdel(this, this.dialogClose) });
			opt.buttons = $t1;
			opt.title = ss.formatString(Q.text('Site.UserRoleDialog.DialogTitle'), this.options.username);
			return opt;
		},
		getTemplate: function() {
			return "<div id='~_Roles'></div>";
		}
	}, ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]), [Serenity.IDialog]);
	ss.initClass($Cengaver_Administration_UserRoleService, $asm, {});
	ss.initClass($Cengaver_Administration_UserService, $asm, {});
	ss.initClass($Cengaver_Common_LanguageSelection, $asm, {
		getLookupAsync: function() {
			return ss.makeGenericType(Serenity.LookupEditorBase$2, [Object, Object]).prototype.getLookupAsync.call(this).then(ss.mkdel(this, function(x) {
				if (!Enumerable.from(x.get_items()).any(ss.mkdel(this, function(z) {
					return ss.referenceEquals(z.LanguageId, this.$currentLanguage);
				}))) {
					var idx = this.$currentLanguage.lastIndexOf('-');
					if (idx >= 0) {
						this.$currentLanguage = this.$currentLanguage.substr(0, idx);
						if (!Enumerable.from(x.get_items()).any(ss.mkdel(this, function(z1) {
							return ss.referenceEquals(z1.LanguageId, this.$currentLanguage);
						}))) {
							this.$currentLanguage = 'en';
						}
					}
					else {
						this.$currentLanguage = 'en';
					}
				}
				return x;
			}), null);
		},
		updateItemsAsync: function() {
			return ss.makeGenericType(Serenity.LookupEditorBase$2, [Object, Object]).prototype.updateItemsAsync.call(this).then(ss.mkdel(this, function() {
				this.set_value(this.$currentLanguage);
			}), null);
		},
		getLookupKey: function() {
			return 'Administration.Language';
		},
		emptyItemText: function() {
			return null;
		}
	}, ss.makeGenericType(Serenity.LookupEditorBase$1, [Object]), [Serenity.IStringValue, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Common_SidebarSearch, $asm, {
		$updateMatchFlags: function(text) {
			var liList = this.$menuUL.find('li').removeClass('non-match');
			text = Q.trimToNull(text);
			if (ss.isNullOrUndefined(text)) {
				liList.removeClass('active');
				liList.show();
				liList.children('ul').addClass('collapse');
				return;
			}
			var parts = ss.netSplit(text, [44, 32].map(function(i) {
				return String.fromCharCode(i);
			}), null, 1);
			for (var i = 0; i < parts.length; i++) {
				parts[i] = Q.trimToNull(Select2.util.stripDiacritics(parts[i]).toUpperCase());
			}
			var items = liList;
			items.each(function(i1, e) {
				var x = $(e);
				var title = Select2.util.stripDiacritics(ss.coalesce(x.text(), '').toUpperCase());
				for (var $t1 = 0; $t1 < parts.length; $t1++) {
					var p = parts[$t1];
					if (ss.isValue(p) && !(title.indexOf(p) !== -1)) {
						x.addClass('non-match');
						break;
					}
				}
			});
			var matchingItems = items.not('.non-match');
			var visibles = matchingItems.parents('li').add(matchingItems);
			var nonVisibles = liList.not(visibles);
			nonVisibles.hide().addClass('non-match');
			visibles.show();
			liList.children('ul').removeClass('collapse');
		}
	}, Serenity.Widget);
	ss.initClass($Cengaver_Membership_LoginForm, $asm, {
		get_username: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Username');
		},
		get_password: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'Password');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Membership_LoginPanel, $asm, {}, ss.makeGenericType(Serenity.PropertyDialog$1, [Object]), [Serenity.IDialog]);
	ss.initClass($Cengaver_Northwind_CategoryDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_CategoryForm, $asm, {
		get_categoryName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CategoryName');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_CategoryGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_CategoryService, $asm, {});
	ss.initClass($Cengaver_Northwind_CustomerCustomerDemoDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_CustomerCustomerDemoForm, $asm, {
		get_customerID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerID');
		},
		get_customerTypeID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerTypeID');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_CustomerCustomerDemoGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'ID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'CustomerID', width: 200, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'CustomerTypeID', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Northwind_CustomerCustomerDemoService, $asm, {});
	ss.initClass($Cengaver_Northwind_CustomerDemographicDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_CustomerDemographicForm, $asm, {
		get_customerTypeID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerTypeID');
		},
		get_customerDesc: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerDesc');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_CustomerDemographicGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'ID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'CustomerTypeID', width: 200, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'CustomerDesc', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Northwind_CustomerDemographicService, $asm, {});
	ss.initClass($Cengaver_Northwind_CustomerDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_CustomerForm, $asm, {
		get_customerID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerID');
		},
		get_companyName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CompanyName');
		},
		get_contactName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactName');
		},
		get_contactTitle: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactTitle');
		},
		get_address: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address');
		},
		get_city: function() {
			return this.byId(Serenity.StringEditor).call(this, 'City');
		},
		get_region: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Region');
		},
		get_postalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PostalCode');
		},
		get_country: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Country');
		},
		get_phone: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Phone');
		},
		get_fax: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Fax');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_CustomerGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Northwind.Customer.Country') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.CustomerCountry';
			this.$country = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.change(this.$country, ss.mkdel(this, function(e1) {
				this.refresh();
			}));
		},
		onViewSubmit: function() {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this)) {
				return false;
			}
			var req = this.view.params;
			req.EqualityFilter = req.EqualityFilter || {};
			req.EqualityFilter['Country'] = this.$country.get_value();
			return true;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_CustomerService, $asm, {});
	ss.initClass($Cengaver_Northwind_EmployeeDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_EmployeeForm, $asm, {
		get_lastName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LastName');
		},
		get_firstName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FirstName');
		},
		get_title: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Title');
		},
		get_titleOfCourtesy: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TitleOfCourtesy');
		},
		get_birthDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'BirthDate');
		},
		get_hireDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'HireDate');
		},
		get_address: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address');
		},
		get_city: function() {
			return this.byId(Serenity.StringEditor).call(this, 'City');
		},
		get_region: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Region');
		},
		get_postalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PostalCode');
		},
		get_country: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Country');
		},
		get_homePhone: function() {
			return this.byId(Serenity.StringEditor).call(this, 'HomePhone');
		},
		get_extension: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Extension');
		},
		get_photo: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Photo');
		},
		get_notes: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Notes');
		},
		get_reportsTo: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ReportsTo');
		},
		get_photoPath: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PhotoPath');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_EmployeeGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'EmployeeID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'LastName', width: 200, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'FirstName', width: 80 });
			columns.push({ field: 'Title', width: 80 });
			columns.push({ field: 'TitleOfCourtesy', width: 80 });
			columns.push({ field: 'BirthDate', width: 80 });
			columns.push({ field: 'HireDate', width: 80 });
			columns.push({ field: 'Address', width: 80 });
			columns.push({ field: 'City', width: 80 });
			columns.push({ field: 'Region', width: 80 });
			columns.push({ field: 'PostalCode', width: 80 });
			columns.push({ field: 'Country', width: 80 });
			columns.push({ field: 'HomePhone', width: 80 });
			columns.push({ field: 'Extension', width: 80 });
			columns.push({ field: 'Photo', width: 80 });
			columns.push({ field: 'Notes', width: 80 });
			columns.push({ field: 'ReportsTo', width: 80 });
			columns.push({ field: 'PhotoPath', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Northwind_EmployeeService, $asm, {});
	ss.initClass($Cengaver_Northwind_EmployeeTerritoryDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_EmployeeTerritoryForm, $asm, {
		get_territoryID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TerritoryID');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_EmployeeTerritoryGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'EmployeeID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'TerritoryID', width: 200, format: this.itemLink(null, null, null, null, true) });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Northwind_EmployeeTerritoryService, $asm, {});
	ss.initClass($Cengaver_Northwind_OrderDetailDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_OrderDetailForm, $asm, {
		get_productID: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ProductID');
		},
		get_unitPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'UnitPrice');
		},
		get_quantity: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Quantity');
		},
		get_discount: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Discount');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_OrderDetailGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'OrderID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'ProductID', width: 80 });
			columns.push({ field: 'UnitPrice', width: 80 });
			columns.push({ field: 'Quantity', width: 80 });
			columns.push({ field: 'Discount', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Northwind_OrderDetailService, $asm, {});
	ss.initClass($Cengaver_Northwind_OrderDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_OrderForm, $asm, {
		get_customerID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerID');
		},
		get_employeeID: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'EmployeeID');
		},
		get_orderDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'OrderDate');
		},
		get_requiredDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'RequiredDate');
		},
		get_shippedDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'ShippedDate');
		},
		get_shipVia: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ShipVia');
		},
		get_freight: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Freight');
		},
		get_shipName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipName');
		},
		get_shipAddress: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipAddress');
		},
		get_shipCity: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipCity');
		},
		get_shipRegion: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipRegion');
		},
		get_shipPostalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipPostalCode');
		},
		get_shipCountry: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipCountry');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_OrderGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'OrderID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'CustomerID', width: 200, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'EmployeeID', width: 80 });
			columns.push({ field: 'OrderDate', width: 80 });
			columns.push({ field: 'RequiredDate', width: 80 });
			columns.push({ field: 'ShippedDate', width: 80 });
			columns.push({ field: 'ShipVia', width: 80 });
			columns.push({ field: 'Freight', width: 80 });
			columns.push({ field: 'ShipName', width: 80 });
			columns.push({ field: 'ShipAddress', width: 80 });
			columns.push({ field: 'ShipCity', width: 80 });
			columns.push({ field: 'ShipRegion', width: 80 });
			columns.push({ field: 'ShipPostalCode', width: 80 });
			columns.push({ field: 'ShipCountry', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Northwind_OrderService, $asm, {});
	ss.initClass($Cengaver_Northwind_PhoneEditor, $asm, {
		formatValue: function() {
			this.element.val(this.getFormattedValue());
		},
		getFormattedValue: function() {
			var value = this.element.val();
			if (this.get_multiple()) {
				return $Cengaver_Northwind_PhoneEditor.$formatMulti(value, $Cengaver_Northwind_PhoneEditor.$formatPhone);
			}
			return $Cengaver_Northwind_PhoneEditor.$formatPhone(value);
		},
		get_multiple: function() {
			return this.$5$MultipleField;
		},
		set_multiple: function(value) {
			this.$5$MultipleField = value;
		},
		get_value: function() {
			return this.getFormattedValue();
		},
		set_value: function(value) {
			this.element.val(value);
		}
	}, Serenity.StringEditor, [Serenity.IStringValue]);
	ss.initClass($Cengaver_Northwind_ProductDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_ProductForm, $asm, {
		get_productName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ProductName');
		},
		get_productImage: function() {
			return this.byId(Serenity.ImageUploadEditor).call(this, 'ProductImage');
		},
		get_discontinued: function() {
			return this.byId(Serenity.BooleanEditor).call(this, 'Discontinued');
		},
		get_supplierID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'SupplierID');
		},
		get_categoryID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'CategoryID');
		},
		get_quantityPerUnit: function() {
			return this.byId(Serenity.StringEditor).call(this, 'QuantityPerUnit');
		},
		get_unitPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'UnitPrice');
		},
		get_unitsInStock: function() {
			return this.byId(Serenity.StringEditor).call(this, 'UnitsInStock');
		},
		get_unitsOnOrder: function() {
			return this.byId(Serenity.StringEditor).call(this, 'UnitsOnOrder');
		},
		get_reorderLevel: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ReorderLevel');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_ProductGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Northwind.Product.SupplierCompanyName') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.Supplier';
			this.$supplier = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.change(this.$supplier, ss.mkdel(this, function(e1) {
				this.refresh();
			}));
			var $t4 = ss.mkdel(this, function(e2) {
				e2.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Northwind.Product.CategoryName') + ' ---');
			});
			var $t3 = Serenity.LookupEditorOptions.$ctor();
			$t3.lookupKey = 'Northwind.Category';
			this.$category = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t4, $t3, null);
			Serenity.WX.change(this.$category, ss.mkdel(this, function(e3) {
				this.refresh();
			}));
		},
		onViewSubmit: function() {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this)) {
				return false;
			}
			var req = this.view.params;
			req.EqualityFilter = req.EqualityFilter || {};
			req.EqualityFilter['SupplierID'] = Serenity.IdExtensions.convertToId(this.$supplier.get_value());
			req.EqualityFilter['CategoryID'] = Serenity.IdExtensions.convertToId(this.$category.get_value());
			return true;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_Northwind_ProductService, $asm, {});
	ss.initClass($Cengaver_Northwind_RegionDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_RegionForm, $asm, {
		get_regionID: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'RegionID');
		},
		get_regionDescription: function() {
			return this.byId(Serenity.StringEditor).call(this, 'RegionDescription');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_RegionGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_RegionService, $asm, {});
	ss.initClass($Cengaver_Northwind_ShipperDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_ShipperForm, $asm, {
		get_companyName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CompanyName');
		},
		get_phone: function() {
			return this.byId($Cengaver_Northwind_PhoneEditor).call(this, 'Phone');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_ShipperGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_ShipperService, $asm, {});
	ss.initClass($Cengaver_Northwind_SupplierDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_SupplierForm, $asm, {
		get_companyName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CompanyName');
		},
		get_contactName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactName');
		},
		get_contactTitle: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactTitle');
		},
		get_address: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address');
		},
		get_city: function() {
			return this.byId(Serenity.StringEditor).call(this, 'City');
		},
		get_region: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Region');
		},
		get_postalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PostalCode');
		},
		get_country: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Country');
		},
		get_phone: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Phone');
		},
		get_fax: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Fax');
		},
		get_homePage: function() {
			return this.byId(Serenity.StringEditor).call(this, 'HomePage');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_SupplierGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Northwind.Supplier.Country') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.SupplierCountry';
			this.$country = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.change(this.$country, ss.mkdel(this, function(e1) {
				this.refresh();
			}));
		},
		onViewSubmit: function() {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this)) {
				return false;
			}
			var req = this.view.params;
			req.EqualityFilter = req.EqualityFilter || {};
			req.EqualityFilter['Country'] = this.$country.get_value();
			return true;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_SupplierService, $asm, {});
	ss.initClass($Cengaver_Northwind_TerritoryDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_TerritoryForm, $asm, {
		get_territoryID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TerritoryID');
		},
		get_territoryDescription: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TerritoryDescription');
		},
		get_regionID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'RegionID');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_Northwind_TerritoryGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Northwind.Territory.RegionDescription') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.Region';
			this.$region = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.change(this.$region, ss.mkdel(this, function(e1) {
				this.refresh();
			}));
		},
		onViewSubmit: function() {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this)) {
				return false;
			}
			var req = this.view.params;
			req.EqualityFilter = req.EqualityFilter || {};
			req.EqualityFilter['RegionID'] = Serenity.IdExtensions.convertToId(this.$region.get_value());
			return true;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($Cengaver_Northwind_TerritoryService, $asm, {});
	ss.initClass($Cengaver_TvHastanesi_CityDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($Cengaver_TvHastanesi_CityForm, $asm, {
		get_city: function() {
			return this.byId(Serenity.StringEditor).call(this, 'City');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_TvHastanesi_CityGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_TvHastanesi_CityService, $asm, {});
	ss.initClass($Cengaver_TvHastanesi_CountyDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($Cengaver_TvHastanesi_CountyEditor, $asm, {
		getLookupKey: function() {
			return 'TvHastanesi.County';
		},
		destroy: function() {
			this.$unbindFromCityEditor();
			ss.makeGenericType(Serenity.LookupEditorBase$2, [Object, Object]).prototype.destroy.call(this);
		},
		getItems: function(lookup) {
			return Enumerable.from(lookup.get_items()).where(ss.mkdel(this, function(x) {
				return ss.referenceEquals(x.CityId, this.get_cityID());
			}));
		},
		$bindToCityEditor: function() {
			if (Q.isEmptyOrNull(this.get_cityEditorID())) {
				return;
			}
			var cityEditor = Serenity.WX.tryGetWidget(Serenity.LookupEditor).call(null, Q.findElementWithRelativeId(this.get_element(), this.get_cityEditorID()));
			if (ss.isValue(cityEditor)) {
				var self = this;
				cityEditor.get_element().bind('change.' + this.uniqueName, ss.mkdel(this, function() {
					this.set_cityID(Serenity.IdExtensions.convertToId(cityEditor.get_value()));
				}));
			}
		},
		$unbindFromCityEditor: function() {
			if (Q.isEmptyOrNull(this.get_cityEditorID())) {
				return;
			}
			var cityEditor = Serenity.WX.tryGetWidget(Serenity.LookupEditor).call(null, Q.findElementWithRelativeId(this.get_element(), this.get_cityEditorID()));
			if (ss.isValue(cityEditor)) {
				cityEditor.get_element().unbind('.' + this.uniqueName);
			}
		},
		get_cityEditorID: function() {
			return this.$cityEditorID;
		},
		set_cityEditorID: function(value) {
			if (!ss.referenceEquals(this.$cityEditorID, value)) {
				this.$unbindFromCityEditor();
				this.$cityEditorID = value;
				this.$bindToCityEditor();
			}
		},
		get_cityID: function() {
			return this.$cityID;
		},
		set_cityID: function(value) {
			if (!ss.referenceEquals(this.$cityID, value)) {
				this.$cityID = value;
				this.set_value(null);
				this.updateItems();
			}
		}
	}, ss.makeGenericType(Serenity.LookupEditorBase$1, [Object]), [Serenity.IStringValue]);
	ss.initClass($Cengaver_TvHastanesi_CountyForm, $asm, {
		get_cityId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'CityId');
		},
		get_county: function() {
			return this.byId(Serenity.StringEditor).call(this, 'County');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_TvHastanesi_CountyGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_TvHastanesi_CountyService, $asm, {});
	ss.initClass($Cengaver_TvHastanesi_CustomerDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($Cengaver_TvHastanesi_CustomerEditor, $asm, {}, ss.makeGenericType(Serenity.LookupEditorBase$2, [Object, Object]), [Serenity.IStringValue]);
	ss.initClass($Cengaver_TvHastanesi_CustomerForm, $asm, {
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_surname: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Surname');
		},
		get_identificationNumber: function() {
			return this.byId(Serenity.StringEditor).call(this, 'IdentificationNumber');
		},
		get_address: function() {
			return this.byId(Serenity.TextAreaEditor).call(this, 'Address');
		},
		get_cityId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'CityId');
		},
		get_countyId: function() {
			return this.byId($Cengaver_TvHastanesi_CountyEditor).call(this, 'CountyId');
		},
		get_phoneNumber: function() {
			return this.byId(Serenity.PhoneEditor).call(this, 'PhoneNumber');
		},
		get_emailAddress: function() {
			return this.byId(Serenity.EmailEditor).call(this, 'EmailAddress');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_TvHastanesi_CustomerGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_TvHastanesi_CustomerService, $asm, {});
	ss.initClass($Cengaver_TvHastanesi_EditorItem, $asm, {});
	ss.initClass($Cengaver_TvHastanesi_MenuDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($Cengaver_TvHastanesi_MenuForm, $asm, {
		get_menu: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Menu');
		},
		get_displayOrder: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'DisplayOrder');
		},
		get_firmId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'FirmId');
		},
		get_webSiteId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'WebSiteId');
		},
		get_path: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Path');
		},
		get_url: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Url');
		},
		get_parentId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ParentId');
		},
		get_rootId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'RootId');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_TvHastanesi_MenuGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_TvHastanesi_MenuService, $asm, {});
	ss.initClass($Cengaver_TvHastanesi_ServiceTicketDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($Cengaver_TvHastanesi_ServiceTicketForm, $asm, {
		get_productSerialNumber: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ProductSerialNumber');
		},
		get_productTypeId: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ProductTypeId');
		},
		get_productMark: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ProductMark');
		},
		get_productModel: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ProductModel');
		},
		get_productDesctiption: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ProductDesctiption');
		},
		get_invoiceNumber: function() {
			return this.byId(Serenity.StringEditor).call(this, 'InvoiceNumber');
		},
		get_receiveDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'ReceiveDate');
		},
		get_deliveryDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'DeliveryDate');
		},
		get_operationId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'OperationId');
		},
		get_stageId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'StageId');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_customerId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'CustomerId');
		},
		get_malFunction: function() {
			return this.byId(Serenity.StringEditor).call(this, 'MalFunction');
		},
		get_technicianNote: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TechnicianNote');
		},
		get_repairCost: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'RepairCost');
		},
		get_laborCost: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'LaborCost');
		},
		get_pieceCost: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'PieceCost');
		},
		get_totalCost: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TotalCost');
		},
		get_paymentTypeId: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PaymentTypeId');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_TvHastanesi_ServiceTicketGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_TvHastanesi_ServiceTicketService, $asm, {});
	ss.initClass($Cengaver_TvHastanesi_UnitDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($Cengaver_TvHastanesi_UnitForm, $asm, {
		get_unit: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Unit');
		},
		get_unitTypeId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UnitTypeId');
		},
		get_path: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Path');
		},
		get_managerId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ManagerId');
		},
		get_firmId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'FirmId');
		},
		get_parentId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ParentId');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($Cengaver_TvHastanesi_UnitGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Cengaver_TvHastanesi_UnitService, $asm, {});
	ss.setMetadata($Cengaver_Administration_LanguageDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('LanguageName'), new Serenity.FormKeyAttribute('Administration.Language'), new Serenity.LocalTextPrefixAttribute('Administration.Language'), new Serenity.ServiceAttribute('Administration/Language')] });
	ss.setMetadata($Cengaver_Administration_LanguageGrid, { attr: [new Serenity.ColumnsKeyAttribute('Administration.Language'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('LanguageName'), new Serenity.DialogTypeAttribute($Cengaver_Administration_LanguageDialog), new Serenity.LocalTextPrefixAttribute('Administration.Language'), new Serenity.ServiceAttribute('Administration/Language')] });
	ss.setMetadata($Cengaver_Administration_PermissionCheckEditor, { attr: [new Serenity.EditorAttribute()] });
	ss.setMetadata($Cengaver_Administration_PermissionModuleEditor, { attr: [new Serenity.EditorAttribute()] });
	ss.setMetadata($Cengaver_Administration_RoleCheckEditor, { attr: [new Serenity.EditorAttribute()] });
	ss.setMetadata($Cengaver_Administration_RoleDialog, { attr: [new Serenity.IdPropertyAttribute('RoleId'), new Serenity.NamePropertyAttribute('RoleName'), new Serenity.FormKeyAttribute('Administration.Role'), new Serenity.LocalTextPrefixAttribute('Administration.Role'), new Serenity.ServiceAttribute('Administration/Role')] });
	ss.setMetadata($Cengaver_Administration_RoleGrid, { attr: [new Serenity.ColumnsKeyAttribute('Administration.Role'), new Serenity.IdPropertyAttribute('RoleId'), new Serenity.NamePropertyAttribute('RoleName'), new Serenity.DialogTypeAttribute($Cengaver_Administration_RoleDialog), new Serenity.LocalTextPrefixAttribute('Administration.Role'), new Serenity.ServiceAttribute('Administration/Role')] });
	ss.setMetadata($Cengaver_Administration_TranslationGrid, { attr: [new Serenity.ColumnsKeyAttribute('Administration.Translation'), new Serenity.IdPropertyAttribute('Key'), new Serenity.LocalTextPrefixAttribute('Administration.Translation'), new Serenity.ServiceAttribute('Administration/Translation')] });
	ss.setMetadata($Cengaver_Administration_UserDialog, { attr: [new Serenity.IdPropertyAttribute('UserId'), new Serenity.NamePropertyAttribute('Username'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Administration.User'), new Serenity.LocalTextPrefixAttribute('Administration.User'), new Serenity.ServiceAttribute('Administration/User')] });
	ss.setMetadata($Cengaver_Administration_UserGrid, { attr: [new Serenity.IdPropertyAttribute('UserId'), new Serenity.NamePropertyAttribute('Username'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($Cengaver_Administration_UserDialog), new Serenity.LocalTextPrefixAttribute('Administration.User'), new Serenity.ServiceAttribute('Administration/User')] });
	ss.setMetadata($Cengaver_Membership_LoginPanel, { attr: [new Serenity.PanelAttribute(), new Serenity.FormKeyAttribute('Membership.Login')] });
	ss.setMetadata($Cengaver_Northwind_CategoryDialog, { attr: [new Serenity.IdPropertyAttribute('CategoryID'), new Serenity.NamePropertyAttribute('CategoryName'), new Serenity.FormKeyAttribute('Northwind.Category'), new Serenity.LocalTextPrefixAttribute('Northwind.Category'), new Serenity.ServiceAttribute('Northwind/Category')] });
	ss.setMetadata($Cengaver_Northwind_CategoryGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Category'), new Serenity.IdPropertyAttribute('CategoryID'), new Serenity.NamePropertyAttribute('CategoryName'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_CategoryDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Category'), new Serenity.ServiceAttribute('Northwind/Category')] });
	ss.setMetadata($Cengaver_Northwind_CustomerCustomerDemoDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.FormKeyAttribute('Northwind.CustomerCustomerDemo'), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerCustomerDemo'), new Serenity.ServiceAttribute('Northwind/CustomerCustomerDemo')] });
	ss.setMetadata($Cengaver_Northwind_CustomerCustomerDemoGrid, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_CustomerCustomerDemoDialog), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerCustomerDemo'), new Serenity.ServiceAttribute('Northwind/CustomerCustomerDemo')] });
	ss.setMetadata($Cengaver_Northwind_CustomerDemographicDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerTypeID'), new Serenity.FormKeyAttribute('Northwind.CustomerDemographic'), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerDemographic'), new Serenity.ServiceAttribute('Northwind/CustomerDemographic')] });
	ss.setMetadata($Cengaver_Northwind_CustomerDemographicGrid, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerTypeID'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_CustomerDemographicDialog), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerDemographic'), new Serenity.ServiceAttribute('Northwind/CustomerDemographic')] });
	ss.setMetadata($Cengaver_Northwind_CustomerDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.FormKeyAttribute('Northwind.Customer'), new Serenity.LocalTextPrefixAttribute('Northwind.Customer'), new Serenity.ServiceAttribute('Northwind/Customer')] });
	ss.setMetadata($Cengaver_Northwind_CustomerGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Customer'), new Serenity.FilterableAttribute(), new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_CustomerDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Customer'), new Serenity.ServiceAttribute('Northwind/Customer')] });
	ss.setMetadata($Cengaver_Northwind_EmployeeDialog, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('LastName'), new Serenity.FormKeyAttribute('Northwind.Employee'), new Serenity.LocalTextPrefixAttribute('Northwind.Employee'), new Serenity.ServiceAttribute('Northwind/Employee')] });
	ss.setMetadata($Cengaver_Northwind_EmployeeGrid, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('LastName'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_EmployeeDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Employee'), new Serenity.ServiceAttribute('Northwind/Employee')] });
	ss.setMetadata($Cengaver_Northwind_EmployeeTerritoryDialog, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.FormKeyAttribute('Northwind.EmployeeTerritory'), new Serenity.LocalTextPrefixAttribute('Northwind.EmployeeTerritory'), new Serenity.ServiceAttribute('Northwind/EmployeeTerritory')] });
	ss.setMetadata($Cengaver_Northwind_EmployeeTerritoryGrid, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_EmployeeTerritoryDialog), new Serenity.LocalTextPrefixAttribute('Northwind.EmployeeTerritory'), new Serenity.ServiceAttribute('Northwind/EmployeeTerritory')] });
	ss.setMetadata($Cengaver_Northwind_OrderDetailDialog, { attr: [new Serenity.IdPropertyAttribute('OrderID'), new Serenity.FormKeyAttribute('Northwind.OrderDetail'), new Serenity.LocalTextPrefixAttribute('Northwind.OrderDetail'), new Serenity.ServiceAttribute('Northwind/OrderDetail')] });
	ss.setMetadata($Cengaver_Northwind_OrderDetailGrid, { attr: [new Serenity.IdPropertyAttribute('OrderID'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_OrderDetailDialog), new Serenity.LocalTextPrefixAttribute('Northwind.OrderDetail'), new Serenity.ServiceAttribute('Northwind/OrderDetail')] });
	ss.setMetadata($Cengaver_Northwind_OrderDialog, { attr: [new Serenity.IdPropertyAttribute('OrderID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.FormKeyAttribute('Northwind.Order'), new Serenity.LocalTextPrefixAttribute('Northwind.Order'), new Serenity.ServiceAttribute('Northwind/Order')] });
	ss.setMetadata($Cengaver_Northwind_OrderGrid, { attr: [new Serenity.IdPropertyAttribute('OrderID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_OrderDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Order'), new Serenity.ServiceAttribute('Northwind/Order')] });
	ss.setMetadata($Cengaver_Northwind_PhoneEditor, { attr: [new Serenity.EditorAttribute()], members: [{ attr: [new Serenity.ComponentModel.OptionAttribute()], name: 'Multiple', type: 16, returnType: Boolean, getter: { name: 'get_Multiple', type: 8, sname: 'get_multiple', returnType: Boolean, params: [] }, setter: { name: 'set_Multiple', type: 8, sname: 'set_multiple', returnType: Object, params: [Boolean] } }] });
	ss.setMetadata($Cengaver_Northwind_ProductDialog, { attr: [new Serenity.IdPropertyAttribute('ProductID'), new Serenity.NamePropertyAttribute('ProductName'), new Serenity.FormKeyAttribute('Northwind.Product'), new Serenity.LocalTextPrefixAttribute('Northwind.Product'), new Serenity.ServiceAttribute('Northwind/Product')] });
	ss.setMetadata($Cengaver_Northwind_ProductGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Product'), new Serenity.FilterableAttribute(), new Serenity.IdPropertyAttribute('ProductID'), new Serenity.NamePropertyAttribute('ProductName'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_ProductDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Product'), new Serenity.ServiceAttribute('Northwind/Product')] });
	ss.setMetadata($Cengaver_Northwind_RegionDialog, { attr: [new Serenity.IdPropertyAttribute('RegionID'), new Serenity.NamePropertyAttribute('RegionDescription'), new Serenity.FormKeyAttribute('Northwind.Region'), new Serenity.LocalTextPrefixAttribute('Northwind.Region'), new Serenity.ServiceAttribute('Northwind/Region')] });
	ss.setMetadata($Cengaver_Northwind_RegionGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Region'), new Serenity.IdPropertyAttribute('RegionID'), new Serenity.NamePropertyAttribute('RegionDescription'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_RegionDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Region'), new Serenity.ServiceAttribute('Northwind/Region')] });
	ss.setMetadata($Cengaver_Northwind_ShipperDialog, { attr: [new Serenity.IdPropertyAttribute('ShipperID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.FormKeyAttribute('Northwind.Shipper'), new Serenity.LocalTextPrefixAttribute('Northwind.Shipper'), new Serenity.ServiceAttribute('Northwind/Shipper')] });
	ss.setMetadata($Cengaver_Northwind_ShipperGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Shipper'), new Serenity.IdPropertyAttribute('ShipperID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_ShipperDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Shipper'), new Serenity.ServiceAttribute('Northwind/Shipper')] });
	ss.setMetadata($Cengaver_Northwind_SupplierDialog, { attr: [new Serenity.IdPropertyAttribute('SupplierID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.FormKeyAttribute('Northwind.Supplier'), new Serenity.LocalTextPrefixAttribute('Northwind.Supplier'), new Serenity.ServiceAttribute('Northwind/Supplier')] });
	ss.setMetadata($Cengaver_Northwind_SupplierGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Supplier'), new Serenity.FilterableAttribute(), new Serenity.IdPropertyAttribute('SupplierID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_SupplierDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Supplier'), new Serenity.ServiceAttribute('Northwind/Supplier')] });
	ss.setMetadata($Cengaver_Northwind_TerritoryDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.FormKeyAttribute('Northwind.Territory'), new Serenity.LocalTextPrefixAttribute('Northwind.Territory'), new Serenity.ServiceAttribute('Northwind/Territory')] });
	ss.setMetadata($Cengaver_Northwind_TerritoryGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Territory'), new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.DialogTypeAttribute($Cengaver_Northwind_TerritoryDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Territory'), new Serenity.ServiceAttribute('Northwind/Territory')] });
	ss.setMetadata($Cengaver_TvHastanesi_CityDialog, { attr: [new Serenity.IdPropertyAttribute('CityId'), new Serenity.NamePropertyAttribute('City'), new Serenity.FormKeyAttribute('TvHastanesi.City'), new Serenity.LocalTextPrefixAttribute('TvHastanesi.City'), new Serenity.ServiceAttribute('TvHastanesi/City')] });
	ss.setMetadata($Cengaver_TvHastanesi_CityGrid, { attr: [new Serenity.ColumnsKeyAttribute('TvHastanesi.City'), new Serenity.IdPropertyAttribute('CityId'), new Serenity.NamePropertyAttribute('City'), new Serenity.DialogTypeAttribute($Cengaver_TvHastanesi_CityDialog), new Serenity.LocalTextPrefixAttribute('TvHastanesi.City'), new Serenity.ServiceAttribute('TvHastanesi/City')] });
	ss.setMetadata($Cengaver_TvHastanesi_CountyDialog, { attr: [new Serenity.IdPropertyAttribute('CountyId'), new Serenity.NamePropertyAttribute('County'), new Serenity.FormKeyAttribute('TvHastanesi.County'), new Serenity.LocalTextPrefixAttribute('TvHastanesi.County'), new Serenity.ServiceAttribute('TvHastanesi/County')] });
	ss.setMetadata($Cengaver_TvHastanesi_CountyEditor, { attr: [new Serenity.EditorAttribute()], members: [{ attr: [new Serenity.ComponentModel.OptionAttribute()], name: 'CityEditorID', type: 16, returnType: String, getter: { name: 'get_CityEditorID', type: 8, sname: 'get_cityEditorID', returnType: String, params: [] }, setter: { name: 'set_CityEditorID', type: 8, sname: 'set_cityEditorID', returnType: Object, params: [String] } }] });
	ss.setMetadata($Cengaver_TvHastanesi_CountyGrid, { attr: [new Serenity.ColumnsKeyAttribute('TvHastanesi.County'), new Serenity.IdPropertyAttribute('CountyId'), new Serenity.NamePropertyAttribute('County'), new Serenity.DialogTypeAttribute($Cengaver_TvHastanesi_CountyDialog), new Serenity.LocalTextPrefixAttribute('TvHastanesi.County'), new Serenity.ServiceAttribute('TvHastanesi/County')] });
	ss.setMetadata($Cengaver_TvHastanesi_CustomerDialog, { attr: [new Serenity.IdPropertyAttribute('CustomerId'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('TvHastanesi.Customer'), new Serenity.LocalTextPrefixAttribute('TvHastanesi.Customer'), new Serenity.ServiceAttribute('TvHastanesi/Customer')] });
	ss.setMetadata($Cengaver_TvHastanesi_CustomerEditor, { attr: [new Serenity.EditorAttribute(), new System.ComponentModel.DisplayNameAttribute('Kampüs')] });
	ss.setMetadata($Cengaver_TvHastanesi_CustomerGrid, { attr: [new Serenity.ColumnsKeyAttribute('TvHastanesi.Customer'), new Serenity.IdPropertyAttribute('CustomerId'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($Cengaver_TvHastanesi_CustomerDialog), new Serenity.LocalTextPrefixAttribute('TvHastanesi.Customer'), new Serenity.ServiceAttribute('TvHastanesi/Customer')] });
	ss.setMetadata($Cengaver_TvHastanesi_MenuDialog, { attr: [new Serenity.IdPropertyAttribute('MenuId'), new Serenity.NamePropertyAttribute('Menu'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('TvHastanesi.Menu'), new Serenity.LocalTextPrefixAttribute('TvHastanesi.Menu'), new Serenity.ServiceAttribute('TvHastanesi/Menu')] });
	ss.setMetadata($Cengaver_TvHastanesi_MenuGrid, { attr: [new Serenity.ColumnsKeyAttribute('TvHastanesi.Menu'), new Serenity.IdPropertyAttribute('MenuId'), new Serenity.NamePropertyAttribute('Menu'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($Cengaver_TvHastanesi_MenuDialog), new Serenity.LocalTextPrefixAttribute('TvHastanesi.Menu'), new Serenity.ServiceAttribute('TvHastanesi/Menu')] });
	ss.setMetadata($Cengaver_TvHastanesi_ServiceTicketDialog, { attr: [new Serenity.IdPropertyAttribute('ServiceTicketId'), new Serenity.NamePropertyAttribute('ProductSerialNumber'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('TvHastanesi.ServiceTicket'), new Serenity.LocalTextPrefixAttribute('TvHastanesi.ServiceTicket'), new Serenity.ServiceAttribute('TvHastanesi/ServiceTicket')] });
	ss.setMetadata($Cengaver_TvHastanesi_ServiceTicketGrid, { attr: [new Serenity.ColumnsKeyAttribute('TvHastanesi.ServiceTicket'), new Serenity.IdPropertyAttribute('ServiceTicketId'), new Serenity.NamePropertyAttribute('ProductSerialNumber'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($Cengaver_TvHastanesi_ServiceTicketDialog), new Serenity.LocalTextPrefixAttribute('TvHastanesi.ServiceTicket'), new Serenity.ServiceAttribute('TvHastanesi/ServiceTicket')] });
	ss.setMetadata($Cengaver_TvHastanesi_UnitDialog, { attr: [new Serenity.IdPropertyAttribute('UnitId'), new Serenity.NamePropertyAttribute('Unit'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('TvHastanesi.Unit'), new Serenity.LocalTextPrefixAttribute('TvHastanesi.Unit'), new Serenity.ServiceAttribute('TvHastanesi/Unit')] });
	ss.setMetadata($Cengaver_TvHastanesi_UnitGrid, { attr: [new Serenity.ColumnsKeyAttribute('TvHastanesi.Unit'), new Serenity.IdPropertyAttribute('UnitId'), new Serenity.NamePropertyAttribute('Unit'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($Cengaver_TvHastanesi_UnitDialog), new Serenity.LocalTextPrefixAttribute('TvHastanesi.Unit'), new Serenity.ServiceAttribute('TvHastanesi/Unit')] });
	(function() {
		Q$Config.rootNamespaces.push('Cengaver');
	})();
})();
