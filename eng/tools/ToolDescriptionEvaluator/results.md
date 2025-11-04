# Tool Selection Analysis Setup

**Setup completed:** 2025-11-03 17:20:25  
**Tool count:** 174  
**Database setup time:** 7.7242678s  

---

# Tool Selection Analysis Results

**Analysis Date:** 2025-11-03 17:20:25  
**Tool count:** 174  

## Table of Contents

- [Test 1: foundry_agents_connect](#test-1)
- [Test 2: foundry_agents_evaluate](#test-2)
- [Test 3: foundry_agents_list](#test-3)
- [Test 4: foundry_agents_list](#test-4)
- [Test 5: foundry_agents_query-and-evaluate](#test-5)
- [Test 6: foundry_knowledge_index_list](#test-6)
- [Test 7: foundry_knowledge_index_list](#test-7)
- [Test 8: foundry_knowledge_index_schema](#test-8)
- [Test 9: foundry_knowledge_index_schema](#test-9)
- [Test 10: foundry_models_deploy](#test-10)
- [Test 11: foundry_models_deployments_list](#test-11)
- [Test 12: foundry_models_deployments_list](#test-12)
- [Test 13: foundry_models_list](#test-13)
- [Test 14: foundry_models_list](#test-14)
- [Test 15: foundry_openai_chat-completions-create](#test-15)
- [Test 16: foundry_openai_create-completion](#test-16)
- [Test 17: foundry_openai_embeddings-create](#test-17)
- [Test 18: foundry_openai_embeddings-create](#test-18)
- [Test 19: foundry_openai_models-list](#test-19)
- [Test 20: foundry_openai_models-list](#test-20)
- [Test 21: foundry_resource_get](#test-21)
- [Test 22: foundry_resource_get](#test-22)
- [Test 23: foundry_resource_get](#test-23)
- [Test 24: search_knowledge_base_get](#test-24)
- [Test 25: search_knowledge_base_get](#test-25)
- [Test 26: search_knowledge_base_get](#test-26)
- [Test 27: search_knowledge_base_get](#test-27)
- [Test 28: search_knowledge_base_get](#test-28)
- [Test 29: search_knowledge_base_get](#test-29)
- [Test 30: search_knowledge_base_retrieve](#test-30)
- [Test 31: search_knowledge_base_retrieve](#test-31)
- [Test 32: search_knowledge_base_retrieve](#test-32)
- [Test 33: search_knowledge_base_retrieve](#test-33)
- [Test 34: search_knowledge_base_retrieve](#test-34)
- [Test 35: search_knowledge_base_retrieve](#test-35)
- [Test 36: search_knowledge_base_retrieve](#test-36)
- [Test 37: search_knowledge_base_retrieve](#test-37)
- [Test 38: search_knowledge_source_get](#test-38)
- [Test 39: search_knowledge_source_get](#test-39)
- [Test 40: search_knowledge_source_get](#test-40)
- [Test 41: search_knowledge_source_get](#test-41)
- [Test 42: search_knowledge_source_get](#test-42)
- [Test 43: search_knowledge_source_get](#test-43)
- [Test 44: search_index_get](#test-44)
- [Test 45: search_index_get](#test-45)
- [Test 46: search_index_get](#test-46)
- [Test 47: search_index_query](#test-47)
- [Test 48: search_service_list](#test-48)
- [Test 49: search_service_list](#test-49)
- [Test 50: search_service_list](#test-50)
- [Test 51: speech_stt_recognize](#test-51)
- [Test 52: speech_stt_recognize](#test-52)
- [Test 53: speech_stt_recognize](#test-53)
- [Test 54: speech_stt_recognize](#test-54)
- [Test 55: speech_stt_recognize](#test-55)
- [Test 56: speech_stt_recognize](#test-56)
- [Test 57: speech_stt_recognize](#test-57)
- [Test 58: speech_stt_recognize](#test-58)
- [Test 59: speech_stt_recognize](#test-59)
- [Test 60: speech_stt_recognize](#test-60)
- [Test 61: appconfig_account_list](#test-61)
- [Test 62: appconfig_account_list](#test-62)
- [Test 63: appconfig_account_list](#test-63)
- [Test 64: appconfig_kv_delete](#test-64)
- [Test 65: appconfig_kv_get](#test-65)
- [Test 66: appconfig_kv_get](#test-66)
- [Test 67: appconfig_kv_get](#test-67)
- [Test 68: appconfig_kv_get](#test-68)
- [Test 69: appconfig_kv_lock_set](#test-69)
- [Test 70: appconfig_kv_lock_set](#test-70)
- [Test 71: appconfig_kv_set](#test-71)
- [Test 72: applens_resource_diagnose](#test-72)
- [Test 73: applens_resource_diagnose](#test-73)
- [Test 74: applens_resource_diagnose](#test-74)
- [Test 75: appservice_database_add](#test-75)
- [Test 76: appservice_database_add](#test-76)
- [Test 77: appservice_database_add](#test-77)
- [Test 78: appservice_database_add](#test-78)
- [Test 79: appservice_database_add](#test-79)
- [Test 80: appservice_database_add](#test-80)
- [Test 81: appservice_database_add](#test-81)
- [Test 82: appservice_database_add](#test-82)
- [Test 83: appservice_database_add](#test-83)
- [Test 84: appservice_database_add](#test-84)
- [Test 85: applicationinsights_recommendation_list](#test-85)
- [Test 86: applicationinsights_recommendation_list](#test-86)
- [Test 87: applicationinsights_recommendation_list](#test-87)
- [Test 88: applicationinsights_recommendation_list](#test-88)
- [Test 89: extension_cli_generate](#test-89)
- [Test 90: extension_cli_generate](#test-90)
- [Test 91: extension_cli_generate](#test-91)
- [Test 92: extension_cli_install](#test-92)
- [Test 93: extension_cli_install](#test-93)
- [Test 94: extension_cli_install](#test-94)
- [Test 95: acr_registry_list](#test-95)
- [Test 96: acr_registry_list](#test-96)
- [Test 97: acr_registry_list](#test-97)
- [Test 98: acr_registry_list](#test-98)
- [Test 99: acr_registry_list](#test-99)
- [Test 100: acr_registry_repository_list](#test-100)
- [Test 101: acr_registry_repository_list](#test-101)
- [Test 102: acr_registry_repository_list](#test-102)
- [Test 103: acr_registry_repository_list](#test-103)
- [Test 104: communication_email_send](#test-104)
- [Test 105: communication_email_send](#test-105)
- [Test 106: communication_email_send](#test-106)
- [Test 107: communication_email_send](#test-107)
- [Test 108: communication_email_send](#test-108)
- [Test 109: communication_email_send](#test-109)
- [Test 110: communication_email_send](#test-110)
- [Test 111: communication_email_send](#test-111)
- [Test 112: communication_sms_send](#test-112)
- [Test 113: communication_sms_send](#test-113)
- [Test 114: communication_sms_send](#test-114)
- [Test 115: communication_sms_send](#test-115)
- [Test 116: communication_sms_send](#test-116)
- [Test 117: communication_sms_send](#test-117)
- [Test 118: communication_sms_send](#test-118)
- [Test 119: communication_sms_send](#test-119)
- [Test 120: confidentialledger_entries_append](#test-120)
- [Test 121: confidentialledger_entries_append](#test-121)
- [Test 122: confidentialledger_entries_append](#test-122)
- [Test 123: confidentialledger_entries_append](#test-123)
- [Test 124: confidentialledger_entries_append](#test-124)
- [Test 125: confidentialledger_entries_get](#test-125)
- [Test 126: confidentialledger_entries_get](#test-126)
- [Test 127: cosmos_account_list](#test-127)
- [Test 128: cosmos_account_list](#test-128)
- [Test 129: cosmos_account_list](#test-129)
- [Test 130: cosmos_database_container_item_query](#test-130)
- [Test 131: cosmos_database_container_list](#test-131)
- [Test 132: cosmos_database_container_list](#test-132)
- [Test 133: cosmos_database_list](#test-133)
- [Test 134: cosmos_database_list](#test-134)
- [Test 135: kusto_cluster_get](#test-135)
- [Test 136: kusto_cluster_list](#test-136)
- [Test 137: kusto_cluster_list](#test-137)
- [Test 138: kusto_cluster_list](#test-138)
- [Test 139: kusto_database_list](#test-139)
- [Test 140: kusto_database_list](#test-140)
- [Test 141: kusto_query](#test-141)
- [Test 142: kusto_sample](#test-142)
- [Test 143: kusto_table_list](#test-143)
- [Test 144: kusto_table_list](#test-144)
- [Test 145: kusto_table_schema](#test-145)
- [Test 146: mysql_database_list](#test-146)
- [Test 147: mysql_database_list](#test-147)
- [Test 148: mysql_database_query](#test-148)
- [Test 149: mysql_server_config_get](#test-149)
- [Test 150: mysql_server_list](#test-150)
- [Test 151: mysql_server_list](#test-151)
- [Test 152: mysql_server_list](#test-152)
- [Test 153: mysql_server_param_get](#test-153)
- [Test 154: mysql_server_param_set](#test-154)
- [Test 155: mysql_table_list](#test-155)
- [Test 156: mysql_table_list](#test-156)
- [Test 157: mysql_table_schema_get](#test-157)
- [Test 158: postgres_database_list](#test-158)
- [Test 159: postgres_database_list](#test-159)
- [Test 160: postgres_database_query](#test-160)
- [Test 161: postgres_server_config_get](#test-161)
- [Test 162: postgres_server_list](#test-162)
- [Test 163: postgres_server_list](#test-163)
- [Test 164: postgres_server_list](#test-164)
- [Test 165: postgres_server_param_get](#test-165)
- [Test 166: postgres_server_param_set](#test-166)
- [Test 167: postgres_table_list](#test-167)
- [Test 168: postgres_table_list](#test-168)
- [Test 169: postgres_table_schema_get](#test-169)
- [Test 170: deploy_app_logs_get](#test-170)
- [Test 171: deploy_architecture_diagram_generate](#test-171)
- [Test 172: deploy_iac_rules_get](#test-172)
- [Test 173: deploy_pipeline_guidance_get](#test-173)
- [Test 174: deploy_plan_get](#test-174)
- [Test 175: eventgrid_events_publish](#test-175)
- [Test 176: eventgrid_events_publish](#test-176)
- [Test 177: eventgrid_events_publish](#test-177)
- [Test 178: eventgrid_topic_list](#test-178)
- [Test 179: eventgrid_topic_list](#test-179)
- [Test 180: eventgrid_topic_list](#test-180)
- [Test 181: eventgrid_topic_list](#test-181)
- [Test 182: eventgrid_subscription_list](#test-182)
- [Test 183: eventgrid_subscription_list](#test-183)
- [Test 184: eventgrid_subscription_list](#test-184)
- [Test 185: eventgrid_subscription_list](#test-185)
- [Test 186: eventgrid_subscription_list](#test-186)
- [Test 187: eventgrid_subscription_list](#test-187)
- [Test 188: eventgrid_subscription_list](#test-188)
- [Test 189: eventhubs_eventhub_consumergroup_delete](#test-189)
- [Test 190: eventhubs_eventhub_consumergroup_get](#test-190)
- [Test 191: eventhubs_eventhub_consumergroup_get](#test-191)
- [Test 192: eventhubs_eventhub_consumergroup_update](#test-192)
- [Test 193: eventhubs_eventhub_consumergroup_update](#test-193)
- [Test 194: eventhubs_eventhub_delete](#test-194)
- [Test 195: eventhubs_eventhub_get](#test-195)
- [Test 196: eventhubs_eventhub_get](#test-196)
- [Test 197: eventhubs_eventhub_update](#test-197)
- [Test 198: eventhubs_eventhub_update](#test-198)
- [Test 199: eventhubs_namespace_delete](#test-199)
- [Test 200: eventhubs_namespace_get](#test-200)
- [Test 201: eventhubs_namespace_get](#test-201)
- [Test 202: eventhubs_namespace_update](#test-202)
- [Test 203: eventhubs_namespace_update](#test-203)
- [Test 204: functionapp_get](#test-204)
- [Test 205: functionapp_get](#test-205)
- [Test 206: functionapp_get](#test-206)
- [Test 207: functionapp_get](#test-207)
- [Test 208: functionapp_get](#test-208)
- [Test 209: functionapp_get](#test-209)
- [Test 210: functionapp_get](#test-210)
- [Test 211: functionapp_get](#test-211)
- [Test 212: functionapp_get](#test-212)
- [Test 213: functionapp_get](#test-213)
- [Test 214: functionapp_get](#test-214)
- [Test 215: functionapp_get](#test-215)
- [Test 216: keyvault_admin_settings_get](#test-216)
- [Test 217: keyvault_admin_settings_get](#test-217)
- [Test 218: keyvault_admin_settings_get](#test-218)
- [Test 219: keyvault_certificate_create](#test-219)
- [Test 220: keyvault_certificate_create](#test-220)
- [Test 221: keyvault_certificate_create](#test-221)
- [Test 222: keyvault_certificate_create](#test-222)
- [Test 223: keyvault_certificate_create](#test-223)
- [Test 224: keyvault_certificate_get](#test-224)
- [Test 225: keyvault_certificate_get](#test-225)
- [Test 226: keyvault_certificate_get](#test-226)
- [Test 227: keyvault_certificate_get](#test-227)
- [Test 228: keyvault_certificate_get](#test-228)
- [Test 229: keyvault_certificate_import](#test-229)
- [Test 230: keyvault_certificate_import](#test-230)
- [Test 231: keyvault_certificate_import](#test-231)
- [Test 232: keyvault_certificate_import](#test-232)
- [Test 233: keyvault_certificate_import](#test-233)
- [Test 234: keyvault_certificate_list](#test-234)
- [Test 235: keyvault_certificate_list](#test-235)
- [Test 236: keyvault_certificate_list](#test-236)
- [Test 237: keyvault_certificate_list](#test-237)
- [Test 238: keyvault_certificate_list](#test-238)
- [Test 239: keyvault_certificate_list](#test-239)
- [Test 240: keyvault_key_create](#test-240)
- [Test 241: keyvault_key_create](#test-241)
- [Test 242: keyvault_key_create](#test-242)
- [Test 243: keyvault_key_create](#test-243)
- [Test 244: keyvault_key_create](#test-244)
- [Test 245: keyvault_key_get](#test-245)
- [Test 246: keyvault_key_get](#test-246)
- [Test 247: keyvault_key_get](#test-247)
- [Test 248: keyvault_key_get](#test-248)
- [Test 249: keyvault_key_get](#test-249)
- [Test 250: keyvault_key_list](#test-250)
- [Test 251: keyvault_key_list](#test-251)
- [Test 252: keyvault_key_list](#test-252)
- [Test 253: keyvault_key_list](#test-253)
- [Test 254: keyvault_key_list](#test-254)
- [Test 255: keyvault_key_list](#test-255)
- [Test 256: keyvault_secret_create](#test-256)
- [Test 257: keyvault_secret_create](#test-257)
- [Test 258: keyvault_secret_create](#test-258)
- [Test 259: keyvault_secret_create](#test-259)
- [Test 260: keyvault_secret_create](#test-260)
- [Test 261: keyvault_secret_get](#test-261)
- [Test 262: keyvault_secret_get](#test-262)
- [Test 263: keyvault_secret_get](#test-263)
- [Test 264: keyvault_secret_get](#test-264)
- [Test 265: keyvault_secret_get](#test-265)
- [Test 266: keyvault_secret_list](#test-266)
- [Test 267: keyvault_secret_list](#test-267)
- [Test 268: keyvault_secret_list](#test-268)
- [Test 269: keyvault_secret_list](#test-269)
- [Test 270: keyvault_secret_list](#test-270)
- [Test 271: keyvault_secret_list](#test-271)
- [Test 272: aks_cluster_get](#test-272)
- [Test 273: aks_cluster_get](#test-273)
- [Test 274: aks_cluster_get](#test-274)
- [Test 275: aks_cluster_get](#test-275)
- [Test 276: aks_cluster_get](#test-276)
- [Test 277: aks_cluster_get](#test-277)
- [Test 278: aks_cluster_get](#test-278)
- [Test 279: aks_nodepool_get](#test-279)
- [Test 280: aks_nodepool_get](#test-280)
- [Test 281: aks_nodepool_get](#test-281)
- [Test 282: aks_nodepool_get](#test-282)
- [Test 283: aks_nodepool_get](#test-283)
- [Test 284: aks_nodepool_get](#test-284)
- [Test 285: loadtesting_test_create](#test-285)
- [Test 286: loadtesting_test_get](#test-286)
- [Test 287: loadtesting_testresource_create](#test-287)
- [Test 288: loadtesting_testresource_list](#test-288)
- [Test 289: loadtesting_testrun_create](#test-289)
- [Test 290: loadtesting_testrun_get](#test-290)
- [Test 291: loadtesting_testrun_list](#test-291)
- [Test 292: loadtesting_testrun_update](#test-292)
- [Test 293: grafana_list](#test-293)
- [Test 294: managedlustre_fs_create](#test-294)
- [Test 295: managedlustre_fs_list](#test-295)
- [Test 296: managedlustre_fs_list](#test-296)
- [Test 297: managedlustre_fs_sku_get](#test-297)
- [Test 298: managedlustre_fs_subnetsize_ask](#test-298)
- [Test 299: managedlustre_fs_subnetsize_validate](#test-299)
- [Test 300: managedlustre_fs_update](#test-300)
- [Test 301: marketplace_product_get](#test-301)
- [Test 302: marketplace_product_list](#test-302)
- [Test 303: marketplace_product_list](#test-303)
- [Test 304: azureagentbestpractices_get](#test-304)
- [Test 305: azureagentbestpractices_get](#test-305)
- [Test 306: azureagentbestpractices_get](#test-306)
- [Test 307: get_bestpractices_get](#test-307)
- [Test 308: get_bestpractices_get](#test-308)
- [Test 309: get_bestpractices_get](#test-309)
- [Test 310: get_bestpractices_get](#test-310)
- [Test 311: get_bestpractices_get](#test-311)
- [Test 312: get_bestpractices_get](#test-312)
- [Test 313: get_bestpractices_get](#test-313)
- [Test 314: get_bestpractices_get](#test-314)
- [Test 315: get_bestpractices_get](#test-315)
- [Test 316: monitor_activitylog_list](#test-316)
- [Test 317: monitor_healthmodels_entity_get](#test-317)
- [Test 318: monitor_metrics_definitions](#test-318)
- [Test 319: monitor_metrics_definitions](#test-319)
- [Test 320: monitor_metrics_definitions](#test-320)
- [Test 321: monitor_metrics_query](#test-321)
- [Test 322: monitor_metrics_query](#test-322)
- [Test 323: monitor_metrics_query](#test-323)
- [Test 324: monitor_metrics_query](#test-324)
- [Test 325: monitor_metrics_query](#test-325)
- [Test 326: monitor_metrics_query](#test-326)
- [Test 327: monitor_resource_log_query](#test-327)
- [Test 328: monitor_table_list](#test-328)
- [Test 329: monitor_table_list](#test-329)
- [Test 330: monitor_table_type_list](#test-330)
- [Test 331: monitor_table_type_list](#test-331)
- [Test 332: monitor_webtests_create](#test-332)
- [Test 333: monitor_webtests_get](#test-333)
- [Test 334: monitor_webtests_list](#test-334)
- [Test 335: monitor_webtests_list](#test-335)
- [Test 336: monitor_webtests_update](#test-336)
- [Test 337: monitor_workspace_list](#test-337)
- [Test 338: monitor_workspace_list](#test-338)
- [Test 339: monitor_workspace_list](#test-339)
- [Test 340: monitor_workspace_log_query](#test-340)
- [Test 341: datadog_monitoredresources_list](#test-341)
- [Test 342: datadog_monitoredresources_list](#test-342)
- [Test 343: extension_azqr](#test-343)
- [Test 344: extension_azqr](#test-344)
- [Test 345: extension_azqr](#test-345)
- [Test 346: quota_region_availability_list](#test-346)
- [Test 347: quota_usage_check](#test-347)
- [Test 348: role_assignment_list](#test-348)
- [Test 349: role_assignment_list](#test-349)
- [Test 350: redis_list](#test-350)
- [Test 351: redis_list](#test-351)
- [Test 352: redis_list](#test-352)
- [Test 353: redis_list](#test-353)
- [Test 354: redis_list](#test-354)
- [Test 355: group_list](#test-355)
- [Test 356: group_list](#test-356)
- [Test 357: group_list](#test-357)
- [Test 358: resourcehealth_availability-status_get](#test-358)
- [Test 359: resourcehealth_availability-status_get](#test-359)
- [Test 360: resourcehealth_availability-status_get](#test-360)
- [Test 361: resourcehealth_availability-status_list](#test-361)
- [Test 362: resourcehealth_availability-status_list](#test-362)
- [Test 363: resourcehealth_availability-status_list](#test-363)
- [Test 364: resourcehealth_health-events_list](#test-364)
- [Test 365: resourcehealth_health-events_list](#test-365)
- [Test 366: resourcehealth_health-events_list](#test-366)
- [Test 367: resourcehealth_health-events_list](#test-367)
- [Test 368: resourcehealth_health-events_list](#test-368)
- [Test 369: servicebus_queue_details](#test-369)
- [Test 370: servicebus_topic_details](#test-370)
- [Test 371: servicebus_topic_subscription_details](#test-371)
- [Test 372: signalr_runtime_get](#test-372)
- [Test 373: signalr_runtime_get](#test-373)
- [Test 374: signalr_runtime_get](#test-374)
- [Test 375: signalr_runtime_get](#test-375)
- [Test 376: signalr_runtime_get](#test-376)
- [Test 377: signalr_runtime_get](#test-377)
- [Test 378: sql_db_create](#test-378)
- [Test 379: sql_db_create](#test-379)
- [Test 380: sql_db_create](#test-380)
- [Test 381: sql_db_delete](#test-381)
- [Test 382: sql_db_delete](#test-382)
- [Test 383: sql_db_delete](#test-383)
- [Test 384: sql_db_list](#test-384)
- [Test 385: sql_db_list](#test-385)
- [Test 386: sql_db_rename](#test-386)
- [Test 387: sql_db_rename](#test-387)
- [Test 388: sql_db_show](#test-388)
- [Test 389: sql_db_show](#test-389)
- [Test 390: sql_db_update](#test-390)
- [Test 391: sql_db_update](#test-391)
- [Test 392: sql_elastic-pool_list](#test-392)
- [Test 393: sql_elastic-pool_list](#test-393)
- [Test 394: sql_elastic-pool_list](#test-394)
- [Test 395: sql_server_create](#test-395)
- [Test 396: sql_server_create](#test-396)
- [Test 397: sql_server_create](#test-397)
- [Test 398: sql_server_delete](#test-398)
- [Test 399: sql_server_delete](#test-399)
- [Test 400: sql_server_delete](#test-400)
- [Test 401: sql_server_entra-admin_list](#test-401)
- [Test 402: sql_server_entra-admin_list](#test-402)
- [Test 403: sql_server_entra-admin_list](#test-403)
- [Test 404: sql_server_firewall-rule_create](#test-404)
- [Test 405: sql_server_firewall-rule_create](#test-405)
- [Test 406: sql_server_firewall-rule_create](#test-406)
- [Test 407: sql_server_firewall-rule_delete](#test-407)
- [Test 408: sql_server_firewall-rule_delete](#test-408)
- [Test 409: sql_server_firewall-rule_delete](#test-409)
- [Test 410: sql_server_firewall-rule_list](#test-410)
- [Test 411: sql_server_firewall-rule_list](#test-411)
- [Test 412: sql_server_firewall-rule_list](#test-412)
- [Test 413: sql_server_list](#test-413)
- [Test 414: sql_server_list](#test-414)
- [Test 415: sql_server_show](#test-415)
- [Test 416: sql_server_show](#test-416)
- [Test 417: sql_server_show](#test-417)
- [Test 418: storage_account_create](#test-418)
- [Test 419: storage_account_create](#test-419)
- [Test 420: storage_account_create](#test-420)
- [Test 421: storage_account_get](#test-421)
- [Test 422: storage_account_get](#test-422)
- [Test 423: storage_account_get](#test-423)
- [Test 424: storage_account_get](#test-424)
- [Test 425: storage_account_get](#test-425)
- [Test 426: storage_blob_container_create](#test-426)
- [Test 427: storage_blob_container_create](#test-427)
- [Test 428: storage_blob_container_create](#test-428)
- [Test 429: storage_blob_container_get](#test-429)
- [Test 430: storage_blob_container_get](#test-430)
- [Test 431: storage_blob_container_get](#test-431)
- [Test 432: storage_blob_get](#test-432)
- [Test 433: storage_blob_get](#test-433)
- [Test 434: storage_blob_get](#test-434)
- [Test 435: storage_blob_get](#test-435)
- [Test 436: storage_blob_upload](#test-436)
- [Test 437: subscription_list](#test-437)
- [Test 438: subscription_list](#test-438)
- [Test 439: subscription_list](#test-439)
- [Test 440: subscription_list](#test-440)
- [Test 441: azureterraformbestpractices_get](#test-441)
- [Test 442: azureterraformbestpractices_get](#test-442)
- [Test 443: virtualdesktop_hostpool_list](#test-443)
- [Test 444: virtualdesktop_hostpool_host_list](#test-444)
- [Test 445: virtualdesktop_hostpool_host_user-list](#test-445)
- [Test 446: workbooks_create](#test-446)
- [Test 447: workbooks_delete](#test-447)
- [Test 448: workbooks_list](#test-448)
- [Test 449: workbooks_list](#test-449)
- [Test 450: workbooks_show](#test-450)
- [Test 451: workbooks_show](#test-451)
- [Test 452: workbooks_update](#test-452)
- [Test 453: bicepschema_get](#test-453)
- [Test 454: cloudarchitect_design](#test-454)
- [Test 455: cloudarchitect_design](#test-455)
- [Test 456: cloudarchitect_design](#test-456)
- [Test 457: cloudarchitect_design](#test-457)

---

## Test 1

**Expected Tool:** `foundry_agents_connect`  
**Prompt:** Query an agent in my Azure AI foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.705410 | `foundry_agents_connect` | ✅ **EXPECTED** |
| 2 | 0.663568 | `foundry_agents_list` | ❌ |
| 3 | 0.617203 | `foundry_resource_get` | ❌ |
| 4 | 0.548044 | `foundry_openai_models-list` | ❌ |
| 5 | 0.537580 | `foundry_agents_query-and-evaluate` | ❌ |

---

## Test 2

**Expected Tool:** `foundry_agents_evaluate`  
**Prompt:** Evaluate the full query and response I got from my agent for task_adherence  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.544099 | `foundry_agents_query-and-evaluate` | ❌ |
| 2 | 0.469428 | `foundry_agents_evaluate` | ✅ **EXPECTED** |
| 3 | 0.445964 | `foundry_agents_connect` | ❌ |
| 4 | 0.278920 | `foundry_agents_list` | ❌ |
| 5 | 0.250023 | `monitor_workspace_log_query` | ❌ |

---

## Test 3

**Expected Tool:** `foundry_agents_list`  
**Prompt:** List all agents in my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.797877 | `foundry_agents_list` | ✅ **EXPECTED** |
| 2 | 0.666025 | `foundry_resource_get` | ❌ |
| 3 | 0.654206 | `foundry_openai_models-list` | ❌ |
| 4 | 0.575553 | `foundry_models_deployments_list` | ❌ |
| 5 | 0.561946 | `search_service_list` | ❌ |

---

## Test 4

**Expected Tool:** `foundry_agents_list`  
**Prompt:** Show me the available agents in my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.749829 | `foundry_agents_list` | ✅ **EXPECTED** |
| 2 | 0.630281 | `foundry_resource_get` | ❌ |
| 3 | 0.611722 | `foundry_openai_models-list` | ❌ |
| 4 | 0.548511 | `foundry_agents_connect` | ❌ |
| 5 | 0.534968 | `foundry_models_list` | ❌ |

---

## Test 5

**Expected Tool:** `foundry_agents_query-and-evaluate`  
**Prompt:** Query and evaluate an agent in my Azure AI Foundry resource for task_adherence  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.652200 | `foundry_agents_connect` | ❌ |
| 2 | 0.570787 | `foundry_agents_list` | ❌ |
| 3 | 0.553190 | `foundry_agents_query-and-evaluate` | ✅ **EXPECTED** |
| 4 | 0.493778 | `foundry_agents_evaluate` | ❌ |
| 5 | 0.481930 | `azureagentbestpractices_get` | ❌ |

---

## Test 6

**Expected Tool:** `foundry_knowledge_index_list`  
**Prompt:** List all knowledge indexes in my AI Foundry project  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.703772 | `foundry_knowledge_index_list` | ✅ **EXPECTED** |
| 2 | 0.537700 | `foundry_agents_list` | ❌ |
| 3 | 0.526733 | `foundry_knowledge_index_schema` | ❌ |
| 4 | 0.475802 | `foundry_models_deployments_list` | ❌ |
| 5 | 0.471613 | `foundry_openai_models-list` | ❌ |

---

## Test 7

**Expected Tool:** `foundry_knowledge_index_list`  
**Prompt:** Show me the knowledge indexes in my AI Foundry project  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.615458 | `foundry_knowledge_index_list` | ✅ **EXPECTED** |
| 2 | 0.489494 | `foundry_knowledge_index_schema` | ❌ |
| 3 | 0.484466 | `foundry_agents_list` | ❌ |
| 4 | 0.441496 | `foundry_resource_get` | ❌ |
| 5 | 0.431360 | `foundry_models_deployments_list` | ❌ |

---

## Test 8

**Expected Tool:** `foundry_knowledge_index_schema`  
**Prompt:** Show me the schema for knowledge index <index-name> in my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.740015 | `foundry_knowledge_index_schema` | ✅ **EXPECTED** |
| 2 | 0.589536 | `foundry_knowledge_index_list` | ❌ |
| 3 | 0.493953 | `foundry_resource_get` | ❌ |
| 4 | 0.491469 | `search_index_get` | ❌ |
| 5 | 0.490410 | `search_knowledge_base_get` | ❌ |

---

## Test 9

**Expected Tool:** `foundry_knowledge_index_schema`  
**Prompt:** Get the schema configuration for knowledge index <index-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.650189 | `foundry_knowledge_index_schema` | ✅ **EXPECTED** |
| 2 | 0.432779 | `postgres_table_schema_get` | ❌ |
| 3 | 0.416680 | `kusto_table_schema` | ❌ |
| 4 | 0.398186 | `mysql_table_schema_get` | ❌ |
| 5 | 0.396194 | `foundry_knowledge_index_list` | ❌ |

---

## Test 10

**Expected Tool:** `foundry_models_deploy`  
**Prompt:** Deploy a GPT4o instance on my resource <resource-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.562920 | `foundry_models_deploy` | ✅ **EXPECTED** |
| 2 | 0.299986 | `foundry_openai_models-list` | ❌ |
| 3 | 0.298490 | `loadtesting_testrun_create` | ❌ |
| 4 | 0.293050 | `loadtesting_testresource_create` | ❌ |
| 5 | 0.290313 | `foundry_openai_embeddings-create` | ❌ |

---

## Test 11

**Expected Tool:** `foundry_models_deployments_list`  
**Prompt:** List all AI Foundry model deployments  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.681385 | `foundry_models_deployments_list` | ✅ **EXPECTED** |
| 2 | 0.674510 | `foundry_openai_models-list` | ❌ |
| 3 | 0.569058 | `foundry_agents_list` | ❌ |
| 4 | 0.566254 | `foundry_resource_get` | ❌ |
| 5 | 0.549647 | `foundry_models_list` | ❌ |

---

## Test 12

**Expected Tool:** `foundry_models_deployments_list`  
**Prompt:** Show me all AI Foundry model deployments  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.620173 | `foundry_models_deployments_list` | ✅ **EXPECTED** |
| 2 | 0.619231 | `foundry_openai_models-list` | ❌ |
| 3 | 0.543332 | `foundry_resource_get` | ❌ |
| 4 | 0.540551 | `foundry_agents_list` | ❌ |
| 5 | 0.521475 | `foundry_models_deploy` | ❌ |

---

## Test 13

**Expected Tool:** `foundry_models_list`  
**Prompt:** List all AI Foundry models  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.603415 | `foundry_openai_models-list` | ❌ |
| 2 | 0.559894 | `foundry_models_list` | ✅ **EXPECTED** |
| 3 | 0.537980 | `foundry_models_deployments_list` | ❌ |
| 4 | 0.519472 | `foundry_agents_list` | ❌ |
| 5 | 0.514265 | `foundry_resource_get` | ❌ |

---

## Test 14

**Expected Tool:** `foundry_models_list`  
**Prompt:** Show me the available AI Foundry models  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.576969 | `foundry_openai_models-list` | ❌ |
| 2 | 0.574839 | `foundry_models_list` | ✅ **EXPECTED** |
| 3 | 0.525477 | `foundry_resource_get` | ❌ |
| 4 | 0.518074 | `foundry_models_deployments_list` | ❌ |
| 5 | 0.504158 | `foundry_agents_list` | ❌ |

---

## Test 15

**Expected Tool:** `foundry_openai_chat-completions-create`  
**Prompt:** Create a chat completion with the message "Hello, how are you today?" using my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.641293 | `foundry_openai_chat-completions-create` | ✅ **EXPECTED** |
| 2 | 0.546867 | `foundry_openai_create-completion` | ❌ |
| 3 | 0.415482 | `foundry_agents_connect` | ❌ |
| 4 | 0.399363 | `foundry_openai_embeddings-create` | ❌ |
| 5 | 0.373420 | `azureagentbestpractices_get` | ❌ |

---

## Test 16

**Expected Tool:** `foundry_openai_create-completion`  
**Prompt:** Create a completion with the prompt "What is Azure?" using my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.696822 | `foundry_openai_create-completion` | ✅ **EXPECTED** |
| 2 | 0.579108 | `foundry_openai_chat-completions-create` | ❌ |
| 3 | 0.463703 | `foundry_models_deploy` | ❌ |
| 4 | 0.459129 | `foundry_resource_get` | ❌ |
| 5 | 0.458614 | `foundry_openai_embeddings-create` | ❌ |

---

## Test 17

**Expected Tool:** `foundry_openai_embeddings-create`  
**Prompt:** Generate embeddings for the text "Azure OpenAI Service" using my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.766363 | `foundry_openai_embeddings-create` | ✅ **EXPECTED** |
| 2 | 0.543339 | `foundry_models_deploy` | ❌ |
| 3 | 0.542109 | `foundry_openai_create-completion` | ❌ |
| 4 | 0.520746 | `foundry_openai_models-list` | ❌ |
| 5 | 0.519385 | `foundry_resource_get` | ❌ |

---

## Test 18

**Expected Tool:** `foundry_openai_embeddings-create`  
**Prompt:** Create vector embeddings for my text using my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.724188 | `foundry_openai_embeddings-create` | ✅ **EXPECTED** |
| 2 | 0.494520 | `foundry_resource_get` | ❌ |
| 3 | 0.480296 | `foundry_models_deploy` | ❌ |
| 4 | 0.480071 | `foundry_openai_create-completion` | ❌ |
| 5 | 0.463797 | `foundry_openai_chat-completions-create` | ❌ |

---

## Test 19

**Expected Tool:** `foundry_openai_models-list`  
**Prompt:** List all available OpenAI models in my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.799059 | `foundry_openai_models-list` | ✅ **EXPECTED** |
| 2 | 0.668910 | `foundry_resource_get` | ❌ |
| 3 | 0.666967 | `foundry_models_list` | ❌ |
| 4 | 0.666208 | `foundry_models_deployments_list` | ❌ |
| 5 | 0.657545 | `foundry_agents_list` | ❌ |

---

## Test 20

**Expected Tool:** `foundry_openai_models-list`  
**Prompt:** Show me the OpenAI model deployments in my Azure AI Foundry resource  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.741659 | `foundry_openai_models-list` | ✅ **EXPECTED** |
| 2 | 0.660160 | `foundry_models_deployments_list` | ❌ |
| 3 | 0.648207 | `foundry_resource_get` | ❌ |
| 4 | 0.640650 | `foundry_models_deploy` | ❌ |
| 5 | 0.619878 | `foundry_agents_list` | ❌ |

---

## Test 21

**Expected Tool:** `foundry_resource_get`  
**Prompt:** List all AI Foundry resources in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.594259 | `foundry_resource_get` | ✅ **EXPECTED** |
| 2 | 0.571958 | `foundry_openai_models-list` | ❌ |
| 3 | 0.567066 | `foundry_agents_list` | ❌ |
| 4 | 0.558302 | `search_service_list` | ❌ |
| 5 | 0.524663 | `grafana_list` | ❌ |

---

## Test 22

**Expected Tool:** `foundry_resource_get`  
**Prompt:** Show me the AI Foundry resources in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.665359 | `foundry_resource_get` | ✅ **EXPECTED** |
| 2 | 0.585305 | `foundry_openai_models-list` | ❌ |
| 3 | 0.553993 | `foundry_agents_list` | ❌ |
| 4 | 0.518657 | `foundry_openai_embeddings-create` | ❌ |
| 5 | 0.492911 | `foundry_models_deploy` | ❌ |

---

## Test 23

**Expected Tool:** `foundry_resource_get`  
**Prompt:** Get details for AI Foundry resource <resource_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.735375 | `foundry_resource_get` | ✅ **EXPECTED** |
| 2 | 0.571906 | `foundry_openai_models-list` | ❌ |
| 3 | 0.510150 | `monitor_webtests_get` | ❌ |
| 4 | 0.496961 | `foundry_openai_embeddings-create` | ❌ |
| 5 | 0.475722 | `foundry_agents_list` | ❌ |

---

## Test 24

**Expected Tool:** `search_knowledge_base_get`  
**Prompt:** List all knowledge bases in the Azure AI Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.785967 | `search_knowledge_base_get` | ✅ **EXPECTED** |
| 2 | 0.700110 | `search_knowledge_source_get` | ❌ |
| 3 | 0.693471 | `search_service_list` | ❌ |
| 4 | 0.635863 | `search_knowledge_base_retrieve` | ❌ |
| 5 | 0.586515 | `search_index_get` | ❌ |

---

## Test 25

**Expected Tool:** `search_knowledge_base_get`  
**Prompt:** Show me the knowledge bases in the Azure AI Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.748213 | `search_knowledge_base_get` | ✅ **EXPECTED** |
| 2 | 0.667762 | `search_knowledge_source_get` | ❌ |
| 3 | 0.628582 | `search_knowledge_base_retrieve` | ❌ |
| 4 | 0.624480 | `search_service_list` | ❌ |
| 5 | 0.566529 | `search_index_get` | ❌ |

---

## Test 26

**Expected Tool:** `search_knowledge_base_get`  
**Prompt:** List all knowledge bases in the search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.702942 | `search_knowledge_base_get` | ✅ **EXPECTED** |
| 2 | 0.604867 | `search_knowledge_source_get` | ❌ |
| 3 | 0.583234 | `search_knowledge_base_retrieve` | ❌ |
| 4 | 0.513638 | `search_service_list` | ❌ |
| 5 | 0.476815 | `foundry_knowledge_index_list` | ❌ |

---

## Test 27

**Expected Tool:** `search_knowledge_base_get`  
**Prompt:** Show me the knowledge bases in the search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.688051 | `search_knowledge_base_get` | ✅ **EXPECTED** |
| 2 | 0.598127 | `search_knowledge_source_get` | ❌ |
| 3 | 0.578499 | `search_knowledge_base_retrieve` | ❌ |
| 4 | 0.457619 | `search_service_list` | ❌ |
| 5 | 0.439528 | `foundry_knowledge_index_list` | ❌ |

---

## Test 28

**Expected Tool:** `search_knowledge_base_get`  
**Prompt:** Get the details of knowledge base <agent-name> in the Azure AI Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.769383 | `search_knowledge_base_get` | ✅ **EXPECTED** |
| 2 | 0.684536 | `search_knowledge_source_get` | ❌ |
| 3 | 0.636958 | `search_knowledge_base_retrieve` | ❌ |
| 4 | 0.585872 | `search_index_get` | ❌ |
| 5 | 0.533701 | `search_service_list` | ❌ |

---

## Test 29

**Expected Tool:** `search_knowledge_base_get`  
**Prompt:** Show me the knowledge base <agent-name> in search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.595585 | `search_knowledge_base_get` | ✅ **EXPECTED** |
| 2 | 0.551922 | `search_knowledge_base_retrieve` | ❌ |
| 3 | 0.514309 | `search_knowledge_source_get` | ❌ |
| 4 | 0.366893 | `search_service_list` | ❌ |
| 5 | 0.365581 | `search_index_get` | ❌ |

---

## Test 30

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** Run a retrieval with knowledge base <agent-name> in Azure AI Search service <service-name> for the query <query>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.724846 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.650590 | `search_knowledge_base_get` | ❌ |
| 3 | 0.575306 | `search_index_query` | ❌ |
| 4 | 0.565966 | `search_knowledge_source_get` | ❌ |
| 5 | 0.520360 | `foundry_agents_connect` | ❌ |

---

## Test 31

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** Ask knowledge base <agent-name> in search service <service-name> to retrieve information about <query>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.633835 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.589867 | `search_knowledge_base_get` | ❌ |
| 3 | 0.501079 | `search_knowledge_source_get` | ❌ |
| 4 | 0.422638 | `foundry_agents_query-and-evaluate` | ❌ |
| 5 | 0.399627 | `search_index_query` | ❌ |

---

## Test 32

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** Run a retrieval with knowledge base <agent-name> in search service <service-name> for the query <query>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.657866 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.557206 | `search_knowledge_base_get` | ❌ |
| 3 | 0.461896 | `search_knowledge_source_get` | ❌ |
| 4 | 0.436739 | `foundry_agents_query-and-evaluate` | ❌ |
| 5 | 0.422173 | `foundry_agents_connect` | ❌ |

---

## Test 33

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** Ask knowledge base <agent-name> in search service <service-name> to retrieve information about <query>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.633766 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.589869 | `search_knowledge_base_get` | ❌ |
| 3 | 0.501070 | `search_knowledge_source_get` | ❌ |
| 4 | 0.422671 | `foundry_agents_query-and-evaluate` | ❌ |
| 5 | 0.399595 | `search_index_query` | ❌ |

---

## Test 34

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** Query knowledge base <agent-name> in search service <service-name> about <query>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.598868 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.547862 | `search_knowledge_base_get` | ❌ |
| 3 | 0.467907 | `foundry_agents_query-and-evaluate` | ❌ |
| 4 | 0.464431 | `search_knowledge_source_get` | ❌ |
| 5 | 0.412481 | `foundry_agents_connect` | ❌ |

---

## Test 35

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** Search knowledge base <agent-name> in Azure AI Search service <service-name> for <query>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.649767 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.631435 | `search_knowledge_base_get` | ❌ |
| 3 | 0.581386 | `search_index_query` | ❌ |
| 4 | 0.570622 | `search_knowledge_source_get` | ❌ |
| 5 | 0.544501 | `search_service_list` | ❌ |

---

## Test 36

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** What does knowledge base <agent-name> in search service <service-name> know about <query>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.579584 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.560407 | `search_knowledge_base_get` | ❌ |
| 3 | 0.476811 | `search_knowledge_source_get` | ❌ |
| 4 | 0.402930 | `foundry_agents_query-and-evaluate` | ❌ |
| 5 | 0.361089 | `foundry_knowledge_index_list` | ❌ |

---

## Test 37

**Expected Tool:** `search_knowledge_base_retrieve`  
**Prompt:** Find information about <query> using knowledge base <agent-name> in search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.581876 | `search_knowledge_base_retrieve` | ✅ **EXPECTED** |
| 2 | 0.527811 | `search_knowledge_base_get` | ❌ |
| 3 | 0.449192 | `foundry_agents_query-and-evaluate` | ❌ |
| 4 | 0.447816 | `search_knowledge_source_get` | ❌ |
| 5 | 0.398328 | `foundry_agents_connect` | ❌ |

---

## Test 38

**Expected Tool:** `search_knowledge_source_get`  
**Prompt:** List all knowledge sources in the Azure AI Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.760769 | `search_knowledge_source_get` | ✅ **EXPECTED** |
| 2 | 0.691931 | `search_service_list` | ❌ |
| 3 | 0.665922 | `search_knowledge_base_get` | ❌ |
| 4 | 0.572951 | `search_index_get` | ❌ |
| 5 | 0.560779 | `search_knowledge_base_retrieve` | ❌ |

---

## Test 39

**Expected Tool:** `search_knowledge_source_get`  
**Prompt:** Show me the knowledge sources in the Azure AI Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.738048 | `search_knowledge_source_get` | ✅ **EXPECTED** |
| 2 | 0.659685 | `search_service_list` | ❌ |
| 3 | 0.652959 | `search_knowledge_base_get` | ❌ |
| 4 | 0.578079 | `search_index_get` | ❌ |
| 5 | 0.560642 | `search_index_query` | ❌ |

---

## Test 40

**Expected Tool:** `search_knowledge_source_get`  
**Prompt:** List all knowledge sources in the search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.658089 | `search_knowledge_source_get` | ✅ **EXPECTED** |
| 2 | 0.558516 | `search_knowledge_base_get` | ❌ |
| 3 | 0.511469 | `search_service_list` | ❌ |
| 4 | 0.470560 | `search_knowledge_base_retrieve` | ❌ |
| 5 | 0.433657 | `foundry_knowledge_index_list` | ❌ |

---

## Test 41

**Expected Tool:** `search_knowledge_source_get`  
**Prompt:** Show me the knowledge sources in the search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.652779 | `search_knowledge_source_get` | ✅ **EXPECTED** |
| 2 | 0.563270 | `search_knowledge_base_get` | ❌ |
| 3 | 0.487022 | `search_service_list` | ❌ |
| 4 | 0.477636 | `search_knowledge_base_retrieve` | ❌ |
| 5 | 0.430528 | `search_index_get` | ❌ |

---

## Test 42

**Expected Tool:** `search_knowledge_source_get`  
**Prompt:** Get the details of knowledge source <source-name> in the Azure AI Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.826039 | `search_knowledge_source_get` | ✅ **EXPECTED** |
| 2 | 0.693438 | `search_knowledge_base_get` | ❌ |
| 3 | 0.595615 | `search_index_get` | ❌ |
| 4 | 0.540550 | `search_knowledge_base_retrieve` | ❌ |
| 5 | 0.531247 | `search_service_list` | ❌ |

---

## Test 43

**Expected Tool:** `search_knowledge_source_get`  
**Prompt:** Show me the knowledge source <source-name> in search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.630992 | `search_knowledge_source_get` | ✅ **EXPECTED** |
| 2 | 0.523643 | `search_knowledge_base_get` | ❌ |
| 3 | 0.459923 | `search_knowledge_base_retrieve` | ❌ |
| 4 | 0.371488 | `search_index_get` | ❌ |
| 5 | 0.370838 | `search_service_list` | ❌ |

---

## Test 44

**Expected Tool:** `search_index_get`  
**Prompt:** Show me the details of the index <index-name> in Cognitive Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.681179 | `search_index_get` | ✅ **EXPECTED** |
| 2 | 0.544604 | `foundry_knowledge_index_schema` | ❌ |
| 3 | 0.528153 | `search_knowledge_base_get` | ❌ |
| 4 | 0.523261 | `search_knowledge_source_get` | ❌ |
| 5 | 0.490625 | `search_service_list` | ❌ |

---

## Test 45

**Expected Tool:** `search_index_get`  
**Prompt:** List all indexes in the Cognitive Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.640330 | `search_index_get` | ✅ **EXPECTED** |
| 2 | 0.620140 | `search_service_list` | ❌ |
| 3 | 0.538885 | `foundry_knowledge_index_list` | ❌ |
| 4 | 0.511485 | `search_knowledge_base_get` | ❌ |
| 5 | 0.497047 | `search_knowledge_source_get` | ❌ |

---

## Test 46

**Expected Tool:** `search_index_get`  
**Prompt:** Show me the indexes in the Cognitive Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.620813 | `search_index_get` | ✅ **EXPECTED** |
| 2 | 0.562775 | `search_service_list` | ❌ |
| 3 | 0.538471 | `foundry_knowledge_index_list` | ❌ |
| 4 | 0.500365 | `search_knowledge_base_get` | ❌ |
| 5 | 0.490834 | `search_knowledge_source_get` | ❌ |

---

## Test 47

**Expected Tool:** `search_index_query`  
**Prompt:** Search for instances of <search_term> in the index <index-name> in Cognitive Search service <service-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.522808 | `search_index_get` | ❌ |
| 2 | 0.515870 | `search_index_query` | ✅ **EXPECTED** |
| 3 | 0.497467 | `search_service_list` | ❌ |
| 4 | 0.447977 | `search_knowledge_base_retrieve` | ❌ |
| 5 | 0.437765 | `postgres_database_query` | ❌ |

---

## Test 48

**Expected Tool:** `search_service_list`  
**Prompt:** List all Cognitive Search services in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.793526 | `search_service_list` | ✅ **EXPECTED** |
| 2 | 0.552939 | `kusto_cluster_list` | ❌ |
| 3 | 0.509368 | `subscription_list` | ❌ |
| 4 | 0.505762 | `search_index_get` | ❌ |
| 5 | 0.504633 | `marketplace_product_list` | ❌ |

---

## Test 49

**Expected Tool:** `search_service_list`  
**Prompt:** Show me the Cognitive Search services in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.686140 | `search_service_list` | ✅ **EXPECTED** |
| 2 | 0.484092 | `marketplace_product_list` | ❌ |
| 3 | 0.479760 | `search_index_get` | ❌ |
| 4 | 0.462337 | `search_knowledge_base_get` | ❌ |
| 5 | 0.461786 | `kusto_cluster_list` | ❌ |

---

## Test 50

**Expected Tool:** `search_service_list`  
**Prompt:** Show me my Cognitive Search services  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.553025 | `search_service_list` | ✅ **EXPECTED** |
| 2 | 0.436156 | `search_index_get` | ❌ |
| 3 | 0.415277 | `search_knowledge_base_get` | ❌ |
| 4 | 0.410964 | `search_knowledge_source_get` | ❌ |
| 5 | 0.404758 | `search_index_query` | ❌ |

---

## Test 51

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Convert this audio file to text using Azure Speech Services  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.665993 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.377041 | `foundry_openai_embeddings-create` | ❌ |
| 3 | 0.351194 | `deploy_plan_get` | ❌ |
| 4 | 0.338209 | `extension_cli_generate` | ❌ |
| 5 | 0.337734 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 52

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Recognize speech from my audio file with language detection  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.511324 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.192427 | `foundry_openai_embeddings-create` | ❌ |
| 3 | 0.170052 | `foundry_openai_create-completion` | ❌ |
| 4 | 0.167159 | `foundry_openai_chat-completions-create` | ❌ |
| 5 | 0.159108 | `foundry_agents_connect` | ❌ |

---

## Test 53

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Transcribe speech from audio file <file_path> with profanity filtering  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.486489 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.160209 | `foundry_agents_connect` | ❌ |
| 3 | 0.156850 | `deploy_pipeline_guidance_get` | ❌ |
| 4 | 0.154634 | `foundry_openai_create-completion` | ❌ |
| 5 | 0.154043 | `foundry_openai_embeddings-create` | ❌ |

---

## Test 54

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Convert speech to text from audio file <file_path> using endpoint <endpoint>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.612026 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.309801 | `foundry_openai_embeddings-create` | ❌ |
| 3 | 0.244207 | `foundry_resource_get` | ❌ |
| 4 | 0.243744 | `foundry_openai_create-completion` | ❌ |
| 5 | 0.242717 | `foundry_openai_chat-completions-create` | ❌ |

---

## Test 55

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Transcribe the audio file <file_path> in Spanish language  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.410533 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.152373 | `foundry_openai_embeddings-create` | ❌ |
| 3 | 0.152137 | `foundry_models_deploy` | ❌ |
| 4 | 0.151632 | `deploy_pipeline_guidance_get` | ❌ |
| 5 | 0.140373 | `deploy_plan_get` | ❌ |

---

## Test 56

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Convert speech to text with detailed output format from audio file <file_path>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.546259 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.218067 | `foundry_resource_get` | ❌ |
| 3 | 0.202874 | `foundry_openai_embeddings-create` | ❌ |
| 4 | 0.183420 | `extension_azqr` | ❌ |
| 5 | 0.180957 | `search_index_get` | ❌ |

---

## Test 57

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Recognize speech from <file_path> with phrase hints for better accuracy  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.539963 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.228579 | `foundry_openai_create-completion` | ❌ |
| 3 | 0.203413 | `foundry_agents_connect` | ❌ |
| 4 | 0.199555 | `foundry_openai_embeddings-create` | ❌ |
| 5 | 0.197301 | `foundry_openai_chat-completions-create` | ❌ |

---

## Test 58

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Transcribe audio using multiple phrase hints: "Azure", "cognitive services", "machine learning"  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.549151 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.382649 | `azureagentbestpractices_get` | ❌ |
| 3 | 0.342537 | `extension_cli_generate` | ❌ |
| 4 | 0.337961 | `cloudarchitect_design` | ❌ |
| 5 | 0.335778 | `foundry_openai_create-completion` | ❌ |

---

## Test 59

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Convert speech to text with comma-separated phrase hints: "Azure, cognitive services, API"  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.532536 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.349924 | `foundry_openai_create-completion` | ❌ |
| 3 | 0.340893 | `foundry_openai_chat-completions-create` | ❌ |
| 4 | 0.332663 | `foundry_openai_embeddings-create` | ❌ |
| 5 | 0.331228 | `azureagentbestpractices_get` | ❌ |

---

## Test 60

**Expected Tool:** `speech_stt_recognize`  
**Prompt:** Transcribe audio with raw profanity output from file <file_path>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.453396 | `speech_stt_recognize` | ✅ **EXPECTED** |
| 2 | 0.173205 | `deploy_pipeline_guidance_get` | ❌ |
| 3 | 0.164935 | `foundry_openai_embeddings-create` | ❌ |
| 4 | 0.160483 | `foundry_agents_connect` | ❌ |
| 5 | 0.160185 | `extension_azqr` | ❌ |

---

## Test 61

**Expected Tool:** `appconfig_account_list`  
**Prompt:** List all App Configuration stores in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.786360 | `appconfig_account_list` | ✅ **EXPECTED** |
| 2 | 0.530613 | `appconfig_kv_get` | ❌ |
| 3 | 0.491380 | `postgres_server_list` | ❌ |
| 4 | 0.481223 | `kusto_cluster_list` | ❌ |
| 5 | 0.479988 | `subscription_list` | ❌ |

---

## Test 62

**Expected Tool:** `appconfig_account_list`  
**Prompt:** Show me the App Configuration stores in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.634978 | `appconfig_account_list` | ✅ **EXPECTED** |
| 2 | 0.464865 | `appconfig_kv_get` | ❌ |
| 3 | 0.398495 | `subscription_list` | ❌ |
| 4 | 0.391291 | `redis_list` | ❌ |
| 5 | 0.372456 | `postgres_server_list` | ❌ |

---

## Test 63

**Expected Tool:** `appconfig_account_list`  
**Prompt:** Show me my App Configuration stores  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.565435 | `appconfig_account_list` | ✅ **EXPECTED** |
| 2 | 0.465344 | `appconfig_kv_get` | ❌ |
| 3 | 0.355916 | `postgres_server_config_get` | ❌ |
| 4 | 0.348661 | `appconfig_kv_delete` | ❌ |
| 5 | 0.327140 | `appconfig_kv_set` | ❌ |

---

## Test 64

**Expected Tool:** `appconfig_kv_delete`  
**Prompt:** Delete the key <key_name> in App Configuration store <app_config_store_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.618121 | `appconfig_kv_delete` | ✅ **EXPECTED** |
| 2 | 0.464263 | `appconfig_kv_get` | ❌ |
| 3 | 0.424265 | `appconfig_kv_set` | ❌ |
| 4 | 0.422688 | `appconfig_kv_lock_set` | ❌ |
| 5 | 0.391794 | `appconfig_account_list` | ❌ |

---

## Test 65

**Expected Tool:** `appconfig_kv_get`  
**Prompt:** List all key-value settings in App Configuration store <app_config_store_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.632687 | `appconfig_kv_get` | ✅ **EXPECTED** |
| 2 | 0.557810 | `appconfig_account_list` | ❌ |
| 3 | 0.530717 | `appconfig_kv_set` | ❌ |
| 4 | 0.464635 | `appconfig_kv_delete` | ❌ |
| 5 | 0.439089 | `appconfig_kv_lock_set` | ❌ |

---

## Test 66

**Expected Tool:** `appconfig_kv_get`  
**Prompt:** Show me the key-value settings in App Configuration store <app_config_store_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.612555 | `appconfig_kv_get` | ✅ **EXPECTED** |
| 2 | 0.522426 | `appconfig_account_list` | ❌ |
| 3 | 0.512774 | `appconfig_kv_set` | ❌ |
| 4 | 0.468503 | `appconfig_kv_delete` | ❌ |
| 5 | 0.457866 | `appconfig_kv_lock_set` | ❌ |

---

## Test 67

**Expected Tool:** `appconfig_kv_get`  
**Prompt:** List all key-value settings with key name starting with 'prod-' in App Configuration store <app_config_store_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.512883 | `appconfig_kv_get` | ✅ **EXPECTED** |
| 2 | 0.449905 | `appconfig_account_list` | ❌ |
| 3 | 0.398592 | `appconfig_kv_set` | ❌ |
| 4 | 0.380614 | `appconfig_kv_delete` | ❌ |
| 5 | 0.346166 | `appconfig_kv_lock_set` | ❌ |

---

## Test 68

**Expected Tool:** `appconfig_kv_get`  
**Prompt:** Show the content for the key <key_name> in App Configuration store <app_config_store_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.552300 | `appconfig_kv_get` | ✅ **EXPECTED** |
| 2 | 0.448833 | `appconfig_kv_set` | ❌ |
| 3 | 0.441713 | `appconfig_kv_delete` | ❌ |
| 4 | 0.437432 | `appconfig_account_list` | ❌ |
| 5 | 0.416264 | `appconfig_kv_lock_set` | ❌ |

---

## Test 69

**Expected Tool:** `appconfig_kv_lock_set`  
**Prompt:** Lock the key <key_name> in App Configuration store <app_config_store_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.591237 | `appconfig_kv_lock_set` | ✅ **EXPECTED** |
| 2 | 0.487174 | `appconfig_kv_get` | ❌ |
| 3 | 0.445489 | `appconfig_kv_set` | ❌ |
| 4 | 0.431516 | `appconfig_kv_delete` | ❌ |
| 5 | 0.373656 | `appconfig_account_list` | ❌ |

---

## Test 70

**Expected Tool:** `appconfig_kv_lock_set`  
**Prompt:** Unlock the key <key_name> in App Configuration store <app_config_store_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.555445 | `appconfig_kv_lock_set` | ✅ **EXPECTED** |
| 2 | 0.506004 | `appconfig_kv_get` | ❌ |
| 3 | 0.476367 | `appconfig_kv_delete` | ❌ |
| 4 | 0.425731 | `appconfig_kv_set` | ❌ |
| 5 | 0.409842 | `appconfig_account_list` | ❌ |

---

## Test 71

**Expected Tool:** `appconfig_kv_set`  
**Prompt:** Set the key <key_name> in App Configuration store <app_config_store_name> to <value>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.608904 | `appconfig_kv_set` | ✅ **EXPECTED** |
| 2 | 0.536778 | `appconfig_kv_lock_set` | ❌ |
| 3 | 0.513345 | `appconfig_kv_get` | ❌ |
| 4 | 0.505776 | `appconfig_kv_delete` | ❌ |
| 5 | 0.377847 | `appconfig_account_list` | ❌ |

---

## Test 72

**Expected Tool:** `applens_resource_diagnose`  
**Prompt:** Please help me diagnose issues with my app using app lens  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.595632 | `applens_resource_diagnose` | ✅ **EXPECTED** |
| 2 | 0.335949 | `deploy_app_logs_get` | ❌ |
| 3 | 0.300786 | `deploy_architecture_diagram_generate` | ❌ |
| 4 | 0.272763 | `cloudarchitect_design` | ❌ |
| 5 | 0.254473 | `monitor_resource_log_query` | ❌ |

---

## Test 73

**Expected Tool:** `applens_resource_diagnose`  
**Prompt:** Use app lens to check why my app is slow?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.502361 | `applens_resource_diagnose` | ✅ **EXPECTED** |
| 2 | 0.316205 | `deploy_app_logs_get` | ❌ |
| 3 | 0.255570 | `deploy_architecture_diagram_generate` | ❌ |
| 4 | 0.249583 | `monitor_resource_log_query` | ❌ |
| 5 | 0.225972 | `quota_usage_check` | ❌ |

---

## Test 74

**Expected Tool:** `applens_resource_diagnose`  
**Prompt:** What does app lens say is wrong with my service?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.492820 | `applens_resource_diagnose` | ✅ **EXPECTED** |
| 2 | 0.256325 | `deploy_architecture_diagram_generate` | ❌ |
| 3 | 0.242667 | `cloudarchitect_design` | ❌ |
| 4 | 0.225608 | `resourcehealth_health-events_list` | ❌ |
| 5 | 0.211556 | `deploy_app_logs_get` | ❌ |

---

## Test 75

**Expected Tool:** `appservice_database_add`  
**Prompt:** Add database connection <connection_string> to my app service <app_name> for database <database_name> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.718159 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.401125 | `sql_db_rename` | ❌ |
| 3 | 0.399953 | `sql_db_create` | ❌ |
| 4 | 0.362421 | `sql_db_show` | ❌ |
| 5 | 0.358204 | `sql_db_list` | ❌ |

---

## Test 76

**Expected Tool:** `appservice_database_add`  
**Prompt:** Configure SQL Server database <database_name> for app service <app_name> with connection string <connection_string> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.688391 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.498100 | `sql_db_rename` | ❌ |
| 3 | 0.497455 | `sql_db_create` | ❌ |
| 4 | 0.469162 | `sql_db_show` | ❌ |
| 5 | 0.452797 | `sql_db_list` | ❌ |

---

## Test 77

**Expected Tool:** `appservice_database_add`  
**Prompt:** Add MySQL database <database_name> to app service <app_name> using connection <connection_string> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.674753 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.464540 | `sql_db_create` | ❌ |
| 3 | 0.452100 | `sql_db_rename` | ❌ |
| 4 | 0.433159 | `mysql_server_list` | ❌ |
| 5 | 0.409740 | `sql_db_show` | ❌ |

---

## Test 78

**Expected Tool:** `appservice_database_add`  
**Prompt:** Add PostgreSQL database <database_name> to app service <app_name> using connection <connection_string> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.627995 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.444152 | `sql_db_create` | ❌ |
| 3 | 0.404689 | `postgres_database_query` | ❌ |
| 4 | 0.401061 | `postgres_database_list` | ❌ |
| 5 | 0.400754 | `sql_db_rename` | ❌ |

---

## Test 79

**Expected Tool:** `appservice_database_add`  
**Prompt:** Connect CosmosDB database <database_name> using connection string <connection_string> to app service <app_name> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.663086 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.446465 | `cosmos_database_list` | ❌ |
| 3 | 0.441966 | `cosmos_database_container_item_query` | ❌ |
| 4 | 0.427284 | `cosmos_database_container_list` | ❌ |
| 5 | 0.420445 | `sql_db_rename` | ❌ |

---

## Test 80

**Expected Tool:** `appservice_database_add`  
**Prompt:** Add database connection <connection_string> for database <database_name> on server <database_server> to app service <app_name> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.733852 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.454554 | `sql_db_create` | ❌ |
| 3 | 0.415274 | `sql_db_rename` | ❌ |
| 4 | 0.414045 | `sql_server_create` | ❌ |
| 5 | 0.410558 | `sql_db_list` | ❌ |

---

## Test 81

**Expected Tool:** `appservice_database_add`  
**Prompt:** Add database connection string for <database_name> to app service <app_name> using connection string <connection_string> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.746522 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.441616 | `sql_db_rename` | ❌ |
| 3 | 0.433929 | `sql_db_create` | ❌ |
| 4 | 0.391725 | `sql_db_list` | ❌ |
| 5 | 0.390203 | `sql_db_show` | ❌ |

---

## Test 82

**Expected Tool:** `appservice_database_add`  
**Prompt:** Connect database <database_name> to my app service <app_name> using connection string <connection_string> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.680460 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.429328 | `sql_db_rename` | ❌ |
| 3 | 0.406335 | `sql_db_create` | ❌ |
| 4 | 0.396559 | `sql_db_show` | ❌ |
| 5 | 0.391861 | `sql_db_list` | ❌ |

---

## Test 83

**Expected Tool:** `appservice_database_add`  
**Prompt:** Set up database <database_name> for app service <app_name> with connection string <connection_string> under resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.640700 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.456993 | `sql_db_create` | ❌ |
| 3 | 0.402902 | `sql_db_rename` | ❌ |
| 4 | 0.402142 | `sql_db_show` | ❌ |
| 5 | 0.394544 | `sql_db_list` | ❌ |

---

## Test 84

**Expected Tool:** `appservice_database_add`  
**Prompt:** Configure database <database_name> for app service <app_name> with the connection string <connection_string> in resource group <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.688527 | `appservice_database_add` | ✅ **EXPECTED** |
| 2 | 0.449170 | `sql_db_rename` | ❌ |
| 3 | 0.448382 | `sql_db_create` | ❌ |
| 4 | 0.414329 | `sql_db_show` | ❌ |
| 5 | 0.411996 | `sql_db_list` | ❌ |

---

## Test 85

**Expected Tool:** `applicationinsights_recommendation_list`  
**Prompt:** List code optimization recommendations across my Application Insights components  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.572473 | `applicationinsights_recommendation_list` | ✅ **EXPECTED** |
| 2 | 0.445157 | `get_bestpractices_get` | ❌ |
| 3 | 0.420991 | `azureagentbestpractices_get` | ❌ |
| 4 | 0.390478 | `azureterraformbestpractices_get` | ❌ |
| 5 | 0.383948 | `applens_resource_diagnose` | ❌ |

---

## Test 86

**Expected Tool:** `applicationinsights_recommendation_list`  
**Prompt:** Show me code optimization recommendations for all Application Insights resources in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.696531 | `applicationinsights_recommendation_list` | ✅ **EXPECTED** |
| 2 | 0.468384 | `get_bestpractices_get` | ❌ |
| 3 | 0.463299 | `azureagentbestpractices_get` | ❌ |
| 4 | 0.452231 | `applens_resource_diagnose` | ❌ |
| 5 | 0.435241 | `azureterraformbestpractices_get` | ❌ |

---

## Test 87

**Expected Tool:** `applicationinsights_recommendation_list`  
**Prompt:** List profiler recommendations for Application Insights in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.626722 | `applicationinsights_recommendation_list` | ✅ **EXPECTED** |
| 2 | 0.487933 | `loadtesting_testresource_list` | ❌ |
| 3 | 0.479392 | `mysql_server_list` | ❌ |
| 4 | 0.477396 | `applens_resource_diagnose` | ❌ |
| 5 | 0.468905 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 88

**Expected Tool:** `applicationinsights_recommendation_list`  
**Prompt:** Show me performance improvement recommendations from Application Insights  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.509502 | `applicationinsights_recommendation_list` | ✅ **EXPECTED** |
| 2 | 0.419670 | `applens_resource_diagnose` | ❌ |
| 3 | 0.409449 | `azureagentbestpractices_get` | ❌ |
| 4 | 0.383767 | `get_bestpractices_get` | ❌ |
| 5 | 0.367278 | `deploy_architecture_diagram_generate` | ❌ |

---

## Test 89

**Expected Tool:** `extension_cli_generate`  
**Prompt:** Create a Storage account with name <storage_account_name> using Azure CLI  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.593143 | `storage_account_create` | ❌ |
| 2 | 0.564888 | `storage_blob_container_create` | ❌ |
| 3 | 0.493624 | `storage_account_get` | ❌ |
| 4 | 0.474320 | `storage_blob_container_get` | ❌ |
| 5 | 0.456013 | `managedlustre_fs_create` | ❌ |

---

## Test 90

**Expected Tool:** `extension_cli_generate`  
**Prompt:** List all virtual machines in my subscription using Azure CLI  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.593467 | `search_service_list` | ❌ |
| 2 | 0.575274 | `kusto_cluster_list` | ❌ |
| 3 | 0.549814 | `virtualdesktop_hostpool_list` | ❌ |
| 4 | 0.544412 | `monitor_workspace_list` | ❌ |
| 5 | 0.536252 | `subscription_list` | ❌ |

---

## Test 91

**Expected Tool:** `extension_cli_generate`  
**Prompt:** Show me the details of the storage account <account_name> with Azure CLI commands  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.710307 | `storage_account_get` | ❌ |
| 2 | 0.602173 | `storage_blob_container_get` | ❌ |
| 3 | 0.543268 | `storage_blob_get` | ❌ |
| 4 | 0.519718 | `storage_account_create` | ❌ |
| 5 | 0.493145 | `cosmos_account_list` | ❌ |

---

## Test 92

**Expected Tool:** `extension_cli_install`  
**Prompt:** <uninstall az cli on your machine and run test prompts for extension_cli_generate>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.497833 | `extension_cli_generate` | ❌ |
| 2 | 0.497483 | `extension_cli_install` | ✅ **EXPECTED** |
| 3 | 0.401540 | `azureterraformbestpractices_get` | ❌ |
| 4 | 0.383665 | `deploy_plan_get` | ❌ |
| 5 | 0.382602 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 93

**Expected Tool:** `extension_cli_install`  
**Prompt:** How to install azd  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.460416 | `extension_cli_install` | ✅ **EXPECTED** |
| 2 | 0.429612 | `deploy_app_logs_get` | ❌ |
| 3 | 0.365202 | `deploy_iac_rules_get` | ❌ |
| 4 | 0.335279 | `deploy_plan_get` | ❌ |
| 5 | 0.326135 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 94

**Expected Tool:** `extension_cli_install`  
**Prompt:** What is Azure Functions Core tools and how to install it  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.622705 | `extension_cli_install` | ✅ **EXPECTED** |
| 2 | 0.439474 | `get_bestpractices_get` | ❌ |
| 3 | 0.432913 | `deploy_pipeline_guidance_get` | ❌ |
| 4 | 0.430723 | `extension_cli_generate` | ❌ |
| 5 | 0.418161 | `deploy_plan_get` | ❌ |

---

## Test 95

**Expected Tool:** `acr_registry_list`  
**Prompt:** List all Azure Container Registries in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.743568 | `acr_registry_list` | ✅ **EXPECTED** |
| 2 | 0.711652 | `acr_registry_repository_list` | ❌ |
| 3 | 0.585675 | `kusto_cluster_list` | ❌ |
| 4 | 0.541506 | `search_service_list` | ❌ |
| 5 | 0.514293 | `cosmos_account_list` | ❌ |

---

## Test 96

**Expected Tool:** `acr_registry_list`  
**Prompt:** Show me my Azure Container Registries  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.586014 | `acr_registry_list` | ✅ **EXPECTED** |
| 2 | 0.563718 | `acr_registry_repository_list` | ❌ |
| 3 | 0.460544 | `storage_blob_container_get` | ❌ |
| 4 | 0.415552 | `cosmos_database_container_list` | ❌ |
| 5 | 0.402247 | `redis_list` | ❌ |

---

## Test 97

**Expected Tool:** `acr_registry_list`  
**Prompt:** Show me the container registries in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.637099 | `acr_registry_list` | ✅ **EXPECTED** |
| 2 | 0.563632 | `acr_registry_repository_list` | ❌ |
| 3 | 0.516697 | `kusto_cluster_list` | ❌ |
| 4 | 0.515343 | `storage_blob_container_get` | ❌ |
| 5 | 0.480278 | `redis_list` | ❌ |

---

## Test 98

**Expected Tool:** `acr_registry_list`  
**Prompt:** List container registries in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.654236 | `acr_registry_repository_list` | ❌ |
| 2 | 0.633938 | `acr_registry_list` | ✅ **EXPECTED** |
| 3 | 0.476015 | `mysql_server_list` | ❌ |
| 4 | 0.454929 | `group_list` | ❌ |
| 5 | 0.454003 | `datadog_monitoredresources_list` | ❌ |

---

## Test 99

**Expected Tool:** `acr_registry_list`  
**Prompt:** Show me the container registries in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.639391 | `acr_registry_list` | ✅ **EXPECTED** |
| 2 | 0.638023 | `acr_registry_repository_list` | ❌ |
| 3 | 0.468028 | `mysql_server_list` | ❌ |
| 4 | 0.449649 | `datadog_monitoredresources_list` | ❌ |
| 5 | 0.445741 | `group_list` | ❌ |

---

## Test 100

**Expected Tool:** `acr_registry_repository_list`  
**Prompt:** List all container registry repositories in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.626532 | `acr_registry_repository_list` | ✅ **EXPECTED** |
| 2 | 0.617504 | `acr_registry_list` | ❌ |
| 3 | 0.544172 | `kusto_cluster_list` | ❌ |
| 4 | 0.508483 | `storage_blob_container_get` | ❌ |
| 5 | 0.495567 | `postgres_server_list` | ❌ |

---

## Test 101

**Expected Tool:** `acr_registry_repository_list`  
**Prompt:** Show me my container registry repositories  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.546307 | `acr_registry_repository_list` | ✅ **EXPECTED** |
| 2 | 0.469295 | `acr_registry_list` | ❌ |
| 3 | 0.451083 | `storage_blob_container_get` | ❌ |
| 4 | 0.407973 | `cosmos_database_container_list` | ❌ |
| 5 | 0.373464 | `storage_blob_get` | ❌ |

---

## Test 102

**Expected Tool:** `acr_registry_repository_list`  
**Prompt:** List repositories in the container registry <registry_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.674152 | `acr_registry_repository_list` | ✅ **EXPECTED** |
| 2 | 0.541779 | `acr_registry_list` | ❌ |
| 3 | 0.437510 | `storage_blob_container_get` | ❌ |
| 4 | 0.433927 | `cosmos_database_container_list` | ❌ |
| 5 | 0.383183 | `kusto_database_list` | ❌ |

---

## Test 103

**Expected Tool:** `acr_registry_repository_list`  
**Prompt:** Show me the repositories in the container registry <registry_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.600712 | `acr_registry_repository_list` | ✅ **EXPECTED** |
| 2 | 0.501842 | `acr_registry_list` | ❌ |
| 3 | 0.430880 | `storage_blob_container_get` | ❌ |
| 4 | 0.418623 | `cosmos_database_container_list` | ❌ |
| 5 | 0.378151 | `redis_list` | ❌ |

---

## Test 104

**Expected Tool:** `communication_email_send`  
**Prompt:** Send an email to <email-address> with subject <subject>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.498292 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.229080 | `communication_sms_send` | ❌ |
| 3 | 0.188846 | `eventgrid_events_publish` | ❌ |
| 4 | 0.145951 | `servicebus_topic_details` | ❌ |
| 5 | 0.142099 | `foundry_openai_chat-completions-create` | ❌ |

---

## Test 105

**Expected Tool:** `communication_email_send`  
**Prompt:** Send an email from my communication service to <email-address>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.498406 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.314462 | `communication_sms_send` | ❌ |
| 3 | 0.235127 | `foundry_openai_chat-completions-create` | ❌ |
| 4 | 0.211154 | `search_knowledge_base_retrieve` | ❌ |
| 5 | 0.194094 | `speech_stt_recognize` | ❌ |

---

## Test 106

**Expected Tool:** `communication_email_send`  
**Prompt:** Send HTML-formatted email to <email-address> with subject <subject>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.520929 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.207563 | `communication_sms_send` | ❌ |
| 3 | 0.152180 | `eventgrid_events_publish` | ❌ |
| 4 | 0.151934 | `servicebus_topic_details` | ❌ |
| 5 | 0.143714 | `foundry_agents_evaluate` | ❌ |

---

## Test 107

**Expected Tool:** `communication_email_send`  
**Prompt:** Send email with CC to <email-address-1> and <email-address-2>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.533447 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.219584 | `communication_sms_send` | ❌ |
| 3 | 0.106026 | `foundry_agents_query-and-evaluate` | ❌ |
| 4 | 0.103723 | `foundry_openai_chat-completions-create` | ❌ |
| 5 | 0.084905 | `cosmos_account_list` | ❌ |

---

## Test 108

**Expected Tool:** `communication_email_send`  
**Prompt:** Send email to multiple recipients: <email-address-1>, <email-address-2>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.540793 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.244521 | `communication_sms_send` | ❌ |
| 3 | 0.134975 | `foundry_openai_chat-completions-create` | ❌ |
| 4 | 0.114324 | `foundry_agents_query-and-evaluate` | ❌ |
| 5 | 0.087035 | `postgres_server_param_set` | ❌ |

---

## Test 109

**Expected Tool:** `communication_email_send`  
**Prompt:** Send email with reply-to address set to <email-address>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.512623 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.200177 | `communication_sms_send` | ❌ |
| 3 | 0.164115 | `mysql_server_param_set` | ❌ |
| 4 | 0.158727 | `postgres_server_param_set` | ❌ |
| 5 | 0.143388 | `appconfig_kv_set` | ❌ |

---

## Test 110

**Expected Tool:** `communication_email_send`  
**Prompt:** Send email with custom sender name <sender-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.473175 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.255169 | `communication_sms_send` | ❌ |
| 3 | 0.164811 | `foundry_openai_chat-completions-create` | ❌ |
| 4 | 0.160315 | `foundry_openai_embeddings-create` | ❌ |
| 5 | 0.156869 | `cosmos_database_container_item_query` | ❌ |

---

## Test 111

**Expected Tool:** `communication_email_send`  
**Prompt:** Send an email with BCC recipients  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.528789 | `communication_email_send` | ✅ **EXPECTED** |
| 2 | 0.241114 | `communication_sms_send` | ❌ |
| 3 | 0.137560 | `confidentialledger_entries_append` | ❌ |
| 4 | 0.108748 | `confidentialledger_entries_get` | ❌ |
| 5 | 0.105036 | `storage_blob_upload` | ❌ |

---

## Test 112

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send an SMS message to <phone-number> saying "Hello"  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.533868 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.251429 | `communication_email_send` | ❌ |
| 3 | 0.218656 | `foundry_openai_chat-completions-create` | ❌ |
| 4 | 0.148584 | `foundry_agents_connect` | ❌ |
| 5 | 0.148564 | `foundry_openai_create-completion` | ❌ |

---

## Test 113

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send SMS to <phone-number-2> from <phone-number-1> with message "Test message"  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.546019 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.294860 | `communication_email_send` | ❌ |
| 3 | 0.204588 | `loadtesting_testrun_create` | ❌ |
| 4 | 0.200655 | `foundry_openai_chat-completions-create` | ❌ |
| 5 | 0.136789 | `loadtesting_testrun_update` | ❌ |

---

## Test 114

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send SMS to multiple recipients: <phone-number-1>, <phone-number-2>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.545755 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.421988 | `communication_email_send` | ❌ |
| 3 | 0.186088 | `foundry_openai_chat-completions-create` | ❌ |
| 4 | 0.142029 | `foundry_agents_query-and-evaluate` | ❌ |
| 5 | 0.104124 | `search_knowledge_base_retrieve` | ❌ |

---

## Test 115

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send SMS with delivery reporting enabled  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.554908 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.269080 | `communication_email_send` | ❌ |
| 3 | 0.191848 | `extension_azqr` | ❌ |
| 4 | 0.185916 | `foundry_openai_chat-completions-create` | ❌ |
| 5 | 0.170726 | `foundry_agents_query-and-evaluate` | ❌ |

---

## Test 116

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send SMS message with custom tracking tag "campaign1"  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.538827 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.269794 | `communication_email_send` | ❌ |
| 3 | 0.188153 | `loadtesting_testrun_create` | ❌ |
| 4 | 0.185403 | `foundry_openai_chat-completions-create` | ❌ |
| 5 | 0.159027 | `appconfig_kv_set` | ❌ |

---

## Test 117

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send broadcast SMS to <phone-number-1> and <phone-number-2> saying "Urgent notification"  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.474786 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.286334 | `communication_email_send` | ❌ |
| 3 | 0.164294 | `foundry_agents_query-and-evaluate` | ❌ |
| 4 | 0.147337 | `foundry_openai_chat-completions-create` | ❌ |
| 5 | 0.128709 | `cosmos_account_list` | ❌ |

---

## Test 118

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send SMS from my communication service to <phone-number-1>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.564114 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.302363 | `communication_email_send` | ❌ |
| 3 | 0.238296 | `foundry_openai_chat-completions-create` | ❌ |
| 4 | 0.183651 | `search_knowledge_base_retrieve` | ❌ |
| 5 | 0.174385 | `foundry_openai_create-completion` | ❌ |

---

## Test 119

**Expected Tool:** `communication_sms_send`  
**Prompt:** Send an SMS with delivery receipt tracking  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.598211 | `communication_sms_send` | ✅ **EXPECTED** |
| 2 | 0.314134 | `communication_email_send` | ❌ |
| 3 | 0.206916 | `foundry_agents_query-and-evaluate` | ❌ |
| 4 | 0.201142 | `foundry_openai_chat-completions-create` | ❌ |
| 5 | 0.187797 | `confidentialledger_entries_append` | ❌ |

---

## Test 120

**Expected Tool:** `confidentialledger_entries_append`  
**Prompt:** Append an entry to my ledger <ledger_name> with data {"key": "value"}  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.510691 | `confidentialledger_entries_append` | ✅ **EXPECTED** |
| 2 | 0.294885 | `confidentialledger_entries_get` | ❌ |
| 3 | 0.291705 | `appconfig_kv_set` | ❌ |
| 4 | 0.258967 | `appconfig_kv_lock_set` | ❌ |
| 5 | 0.249908 | `keyvault_certificate_import` | ❌ |

---

## Test 121

**Expected Tool:** `confidentialledger_entries_append`  
**Prompt:** Write a tamper-proof entry to ledger <ledger_name> containing {"transaction": "data"}  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.602272 | `confidentialledger_entries_append` | ✅ **EXPECTED** |
| 2 | 0.357646 | `confidentialledger_entries_get` | ❌ |
| 3 | 0.211990 | `appconfig_kv_lock_set` | ❌ |
| 4 | 0.195471 | `keyvault_secret_create` | ❌ |
| 5 | 0.184077 | `keyvault_certificate_import` | ❌ |

---

## Test 122

**Expected Tool:** `confidentialledger_entries_append`  
**Prompt:** Append {"hello": "from mcp"} to my confidential ledger <ledger_name> in collection <collection_id>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.546565 | `confidentialledger_entries_append` | ✅ **EXPECTED** |
| 2 | 0.452081 | `confidentialledger_entries_get` | ❌ |
| 3 | 0.225004 | `appconfig_kv_lock_set` | ❌ |
| 4 | 0.215702 | `appconfig_kv_set` | ❌ |
| 5 | 0.203310 | `keyvault_certificate_import` | ❌ |

---

## Test 123

**Expected Tool:** `confidentialledger_entries_append`  
**Prompt:** Create an immutable ledger entry in <ledger_name> with content {"audit": "log"}  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.496037 | `confidentialledger_entries_append` | ✅ **EXPECTED** |
| 2 | 0.340187 | `confidentialledger_entries_get` | ❌ |
| 3 | 0.218473 | `monitor_activitylog_list` | ❌ |
| 4 | 0.215229 | `storage_blob_container_create` | ❌ |
| 5 | 0.204925 | `monitor_resource_log_query` | ❌ |

---

## Test 124

**Expected Tool:** `confidentialledger_entries_append`  
**Prompt:** Write an entry to confidential ledger <ledger_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.622179 | `confidentialledger_entries_append` | ✅ **EXPECTED** |
| 2 | 0.524777 | `confidentialledger_entries_get` | ❌ |
| 3 | 0.252508 | `appconfig_kv_lock_set` | ❌ |
| 4 | 0.240252 | `keyvault_secret_create` | ❌ |
| 5 | 0.186625 | `appconfig_kv_set` | ❌ |

---

## Test 125

**Expected Tool:** `confidentialledger_entries_get`  
**Prompt:** Get entry from Confidential Ledger for transaction <transaction_id> on ledger <ledger_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.707252 | `confidentialledger_entries_get` | ✅ **EXPECTED** |
| 2 | 0.552052 | `confidentialledger_entries_append` | ❌ |
| 3 | 0.245541 | `keyvault_secret_get` | ❌ |
| 4 | 0.229943 | `keyvault_key_get` | ❌ |
| 5 | 0.211839 | `loadtesting_testrun_get` | ❌ |

---

## Test 126

**Expected Tool:** `confidentialledger_entries_get`  
**Prompt:** Get transaction <transaction_id> from ledger <ledger_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.509714 | `confidentialledger_entries_get` | ✅ **EXPECTED** |
| 2 | 0.416670 | `confidentialledger_entries_append` | ❌ |
| 3 | 0.223959 | `loadtesting_testrun_get` | ❌ |
| 4 | 0.218412 | `monitor_resource_log_query` | ❌ |
| 5 | 0.217671 | `loadtesting_testrun_list` | ❌ |

---

## Test 127

**Expected Tool:** `cosmos_account_list`  
**Prompt:** List all cosmosdb accounts in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.818357 | `cosmos_account_list` | ✅ **EXPECTED** |
| 2 | 0.668480 | `cosmos_database_list` | ❌ |
| 3 | 0.636036 | `subscription_list` | ❌ |
| 4 | 0.615268 | `cosmos_database_container_list` | ❌ |
| 5 | 0.601467 | `kusto_cluster_list` | ❌ |

---

## Test 128

**Expected Tool:** `cosmos_account_list`  
**Prompt:** Show me my cosmosdb accounts  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.665447 | `cosmos_account_list` | ✅ **EXPECTED** |
| 2 | 0.605357 | `cosmos_database_list` | ❌ |
| 3 | 0.571613 | `cosmos_database_container_list` | ❌ |
| 4 | 0.549447 | `cosmos_database_container_item_query` | ❌ |
| 5 | 0.503830 | `storage_account_get` | ❌ |

---

## Test 129

**Expected Tool:** `cosmos_account_list`  
**Prompt:** Show me the cosmosdb accounts in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.752494 | `cosmos_account_list` | ✅ **EXPECTED** |
| 2 | 0.607201 | `subscription_list` | ❌ |
| 3 | 0.605125 | `cosmos_database_list` | ❌ |
| 4 | 0.566249 | `cosmos_database_container_list` | ❌ |
| 5 | 0.563922 | `cosmos_database_container_item_query` | ❌ |

---

## Test 130

**Expected Tool:** `cosmos_database_container_item_query`  
**Prompt:** Show me the items that contain the word <search_term> in the container <container_name> in the database <database_name> for the cosmosdb account <account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.658701 | `cosmos_database_container_item_query` | ✅ **EXPECTED** |
| 2 | 0.605253 | `cosmos_database_container_list` | ❌ |
| 3 | 0.487612 | `storage_blob_container_get` | ❌ |
| 4 | 0.477874 | `cosmos_database_list` | ❌ |
| 5 | 0.447757 | `cosmos_account_list` | ❌ |

---

## Test 131

**Expected Tool:** `cosmos_database_container_list`  
**Prompt:** List all the containers in the database <database_name> for the cosmosdb account <account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.852832 | `cosmos_database_container_list` | ✅ **EXPECTED** |
| 2 | 0.681044 | `cosmos_database_list` | ❌ |
| 3 | 0.680762 | `cosmos_database_container_item_query` | ❌ |
| 4 | 0.632335 | `storage_blob_container_get` | ❌ |
| 5 | 0.630659 | `cosmos_account_list` | ❌ |

---

## Test 132

**Expected Tool:** `cosmos_database_container_list`  
**Prompt:** Show me the containers in the database <database_name> for the cosmosdb account <account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.789395 | `cosmos_database_container_list` | ✅ **EXPECTED** |
| 2 | 0.648126 | `cosmos_database_container_item_query` | ❌ |
| 3 | 0.614220 | `cosmos_database_list` | ❌ |
| 4 | 0.591361 | `storage_blob_container_get` | ❌ |
| 5 | 0.562062 | `cosmos_account_list` | ❌ |

---

## Test 133

**Expected Tool:** `cosmos_database_list`  
**Prompt:** List all the databases in the cosmosdb account <account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.815683 | `cosmos_database_list` | ✅ **EXPECTED** |
| 2 | 0.668515 | `cosmos_account_list` | ❌ |
| 3 | 0.665298 | `cosmos_database_container_list` | ❌ |
| 4 | 0.606433 | `cosmos_database_container_item_query` | ❌ |
| 5 | 0.583535 | `kusto_database_list` | ❌ |

---

## Test 134

**Expected Tool:** `cosmos_database_list`  
**Prompt:** Show me the databases in the cosmosdb account <account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.749370 | `cosmos_database_list` | ✅ **EXPECTED** |
| 2 | 0.624759 | `cosmos_database_container_list` | ❌ |
| 3 | 0.614572 | `cosmos_account_list` | ❌ |
| 4 | 0.579919 | `cosmos_database_container_item_query` | ❌ |
| 5 | 0.538479 | `mysql_database_list` | ❌ |

---

## Test 135

**Expected Tool:** `kusto_cluster_get`  
**Prompt:** Show me the details of the Data Explorer cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.590264 | `kusto_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.463832 | `kusto_cluster_list` | ❌ |
| 3 | 0.428159 | `kusto_query` | ❌ |
| 4 | 0.426503 | `kusto_table_schema` | ❌ |
| 5 | 0.425669 | `kusto_database_list` | ❌ |

---

## Test 136

**Expected Tool:** `kusto_cluster_list`  
**Prompt:** List all Data Explorer clusters in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.793744 | `kusto_cluster_list` | ✅ **EXPECTED** |
| 2 | 0.630507 | `kusto_database_list` | ❌ |
| 3 | 0.573395 | `kusto_cluster_get` | ❌ |
| 4 | 0.525025 | `aks_cluster_get` | ❌ |
| 5 | 0.509397 | `grafana_list` | ❌ |

---

## Test 137

**Expected Tool:** `kusto_cluster_list`  
**Prompt:** Show me my Data Explorer clusters  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.531307 | `kusto_cluster_list` | ✅ **EXPECTED** |
| 2 | 0.465277 | `kusto_cluster_get` | ❌ |
| 3 | 0.432288 | `kusto_database_list` | ❌ |
| 4 | 0.369596 | `aks_cluster_get` | ❌ |
| 5 | 0.367768 | `kusto_table_schema` | ❌ |

---

## Test 138

**Expected Tool:** `kusto_cluster_list`  
**Prompt:** Show me the Data Explorer clusters in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.701484 | `kusto_cluster_list` | ✅ **EXPECTED** |
| 2 | 0.571191 | `kusto_cluster_get` | ❌ |
| 3 | 0.548685 | `kusto_database_list` | ❌ |
| 4 | 0.498909 | `aks_cluster_get` | ❌ |
| 5 | 0.474201 | `redis_list` | ❌ |

---

## Test 139

**Expected Tool:** `kusto_database_list`  
**Prompt:** List all databases in the Data Explorer cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.677059 | `kusto_database_list` | ✅ **EXPECTED** |
| 2 | 0.560592 | `kusto_cluster_list` | ❌ |
| 3 | 0.556795 | `kusto_table_list` | ❌ |
| 4 | 0.553213 | `postgres_database_list` | ❌ |
| 5 | 0.549673 | `cosmos_database_list` | ❌ |

---

## Test 140

**Expected Tool:** `kusto_database_list`  
**Prompt:** Show me the databases in the Data Explorer cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.623523 | `kusto_database_list` | ✅ **EXPECTED** |
| 2 | 0.509952 | `kusto_cluster_list` | ❌ |
| 3 | 0.507073 | `kusto_table_list` | ❌ |
| 4 | 0.497144 | `cosmos_database_list` | ❌ |
| 5 | 0.491400 | `mysql_database_list` | ❌ |

---

## Test 141

**Expected Tool:** `kusto_query`  
**Prompt:** Show me all items that contain the word <search_term> in the Data Explorer table <table_name> in cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.423528 | `kusto_query` | ✅ **EXPECTED** |
| 2 | 0.410961 | `kusto_table_schema` | ❌ |
| 3 | 0.409488 | `postgres_database_query` | ❌ |
| 4 | 0.407884 | `kusto_sample` | ❌ |
| 5 | 0.403929 | `kusto_cluster_list` | ❌ |

---

## Test 142

**Expected Tool:** `kusto_sample`  
**Prompt:** Show me a data sample from the Data Explorer table <table_name> in cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.595598 | `kusto_sample` | ✅ **EXPECTED** |
| 2 | 0.514394 | `kusto_table_schema` | ❌ |
| 3 | 0.424244 | `kusto_table_list` | ❌ |
| 4 | 0.400910 | `kusto_cluster_list` | ❌ |
| 5 | 0.399493 | `kusto_cluster_get` | ❌ |

---

## Test 143

**Expected Tool:** `kusto_table_list`  
**Prompt:** List all tables in the Data Explorer database <database_name> in cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.679642 | `kusto_table_list` | ✅ **EXPECTED** |
| 2 | 0.585237 | `postgres_table_list` | ❌ |
| 3 | 0.581207 | `kusto_database_list` | ❌ |
| 4 | 0.556724 | `mysql_table_list` | ❌ |
| 5 | 0.549947 | `monitor_table_list` | ❌ |

---

## Test 144

**Expected Tool:** `kusto_table_list`  
**Prompt:** Show me the tables in the Data Explorer database <database_name> in cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.619252 | `kusto_table_list` | ✅ **EXPECTED** |
| 2 | 0.559094 | `kusto_table_schema` | ❌ |
| 3 | 0.527625 | `kusto_database_list` | ❌ |
| 4 | 0.524691 | `mysql_table_list` | ❌ |
| 5 | 0.523432 | `postgres_table_list` | ❌ |

---

## Test 145

**Expected Tool:** `kusto_table_schema`  
**Prompt:** Show me the schema for table <table_name> in the Data Explorer database <database_name> in cluster <cluster_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.671066 | `kusto_table_schema` | ✅ **EXPECTED** |
| 2 | 0.564330 | `postgres_table_schema_get` | ❌ |
| 3 | 0.527917 | `mysql_table_schema_get` | ❌ |
| 4 | 0.490880 | `kusto_sample` | ❌ |
| 5 | 0.489680 | `kusto_table_list` | ❌ |

---

## Test 146

**Expected Tool:** `mysql_database_list`  
**Prompt:** List all MySQL databases in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.634033 | `postgres_database_list` | ❌ |
| 2 | 0.623421 | `mysql_database_list` | ✅ **EXPECTED** |
| 3 | 0.534457 | `mysql_table_list` | ❌ |
| 4 | 0.498918 | `mysql_server_list` | ❌ |
| 5 | 0.490039 | `sql_db_list` | ❌ |

---

## Test 147

**Expected Tool:** `mysql_database_list`  
**Prompt:** Show me the MySQL databases in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.588035 | `mysql_database_list` | ✅ **EXPECTED** |
| 2 | 0.573976 | `postgres_database_list` | ❌ |
| 3 | 0.483784 | `mysql_table_list` | ❌ |
| 4 | 0.463198 | `mysql_server_list` | ❌ |
| 5 | 0.444535 | `sql_db_list` | ❌ |

---

## Test 148

**Expected Tool:** `mysql_database_query`  
**Prompt:** Show me all items that contain the word <search_term> in the MySQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.476423 | `mysql_table_list` | ❌ |
| 2 | 0.455770 | `mysql_database_list` | ❌ |
| 3 | 0.433392 | `mysql_database_query` | ✅ **EXPECTED** |
| 4 | 0.419859 | `mysql_server_list` | ❌ |
| 5 | 0.409445 | `mysql_table_schema_get` | ❌ |

---

## Test 149

**Expected Tool:** `mysql_server_config_get`  
**Prompt:** Show me the configuration of MySQL server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.531887 | `postgres_server_config_get` | ❌ |
| 2 | 0.516893 | `mysql_server_param_set` | ❌ |
| 3 | 0.489816 | `mysql_server_config_get` | ✅ **EXPECTED** |
| 4 | 0.476863 | `mysql_server_param_get` | ❌ |
| 5 | 0.426507 | `mysql_table_schema_get` | ❌ |

---

## Test 150

**Expected Tool:** `mysql_server_list`  
**Prompt:** List all MySQL servers in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.678473 | `postgres_server_list` | ❌ |
| 2 | 0.558177 | `mysql_database_list` | ❌ |
| 3 | 0.554818 | `mysql_server_list` | ✅ **EXPECTED** |
| 4 | 0.513706 | `kusto_cluster_list` | ❌ |
| 5 | 0.501199 | `mysql_table_list` | ❌ |

---

## Test 151

**Expected Tool:** `mysql_server_list`  
**Prompt:** Show me my MySQL servers  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.478518 | `mysql_database_list` | ❌ |
| 2 | 0.474586 | `mysql_server_list` | ✅ **EXPECTED** |
| 3 | 0.435642 | `postgres_server_list` | ❌ |
| 4 | 0.412380 | `mysql_table_list` | ❌ |
| 5 | 0.389883 | `postgres_database_list` | ❌ |

---

## Test 152

**Expected Tool:** `mysql_server_list`  
**Prompt:** Show me the MySQL servers in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.636435 | `postgres_server_list` | ❌ |
| 2 | 0.534266 | `mysql_server_list` | ✅ **EXPECTED** |
| 3 | 0.530210 | `mysql_database_list` | ❌ |
| 4 | 0.475052 | `kusto_cluster_list` | ❌ |
| 5 | 0.470468 | `redis_list` | ❌ |

---

## Test 153

**Expected Tool:** `mysql_server_param_get`  
**Prompt:** Show me the value of connection timeout in seconds in my MySQL server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.495071 | `mysql_server_param_get` | ✅ **EXPECTED** |
| 2 | 0.438075 | `mysql_server_param_set` | ❌ |
| 3 | 0.333841 | `mysql_database_query` | ❌ |
| 4 | 0.313150 | `mysql_table_schema_get` | ❌ |
| 5 | 0.310834 | `postgres_server_param_get` | ❌ |

---

## Test 154

**Expected Tool:** `mysql_server_param_set`  
**Prompt:** Set connection timeout to 20 seconds for my MySQL server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.449459 | `mysql_server_param_set` | ✅ **EXPECTED** |
| 2 | 0.381150 | `mysql_server_param_get` | ❌ |
| 3 | 0.303332 | `postgres_server_param_set` | ❌ |
| 4 | 0.298887 | `mysql_database_query` | ❌ |
| 5 | 0.254187 | `mysql_server_list` | ❌ |

---

## Test 155

**Expected Tool:** `mysql_table_list`  
**Prompt:** List all tables in the MySQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.633448 | `mysql_table_list` | ✅ **EXPECTED** |
| 2 | 0.573844 | `postgres_table_list` | ❌ |
| 3 | 0.550914 | `postgres_database_list` | ❌ |
| 4 | 0.546963 | `mysql_database_list` | ❌ |
| 5 | 0.511847 | `kusto_table_list` | ❌ |

---

## Test 156

**Expected Tool:** `mysql_table_list`  
**Prompt:** Show me the tables in the MySQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.609131 | `mysql_table_list` | ✅ **EXPECTED** |
| 2 | 0.526236 | `postgres_table_list` | ❌ |
| 3 | 0.525709 | `mysql_database_list` | ❌ |
| 4 | 0.507258 | `mysql_table_schema_get` | ❌ |
| 5 | 0.497986 | `postgres_database_list` | ❌ |

---

## Test 157

**Expected Tool:** `mysql_table_schema_get`  
**Prompt:** Show me the schema of table <table> in the MySQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.630623 | `mysql_table_schema_get` | ✅ **EXPECTED** |
| 2 | 0.558320 | `postgres_table_schema_get` | ❌ |
| 3 | 0.545025 | `mysql_table_list` | ❌ |
| 4 | 0.522747 | `kusto_table_schema` | ❌ |
| 5 | 0.457739 | `mysql_database_list` | ❌ |

---

## Test 158

**Expected Tool:** `postgres_database_list`  
**Prompt:** List all PostgreSQL databases in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.815577 | `postgres_database_list` | ✅ **EXPECTED** |
| 2 | 0.644014 | `postgres_table_list` | ❌ |
| 3 | 0.622790 | `postgres_server_list` | ❌ |
| 4 | 0.542685 | `postgres_server_config_get` | ❌ |
| 5 | 0.490904 | `postgres_server_param_get` | ❌ |

---

## Test 159

**Expected Tool:** `postgres_database_list`  
**Prompt:** Show me the PostgreSQL databases in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.759921 | `postgres_database_list` | ✅ **EXPECTED** |
| 2 | 0.589784 | `postgres_server_list` | ❌ |
| 3 | 0.585891 | `postgres_table_list` | ❌ |
| 4 | 0.552660 | `postgres_server_config_get` | ❌ |
| 5 | 0.495629 | `postgres_server_param_get` | ❌ |

---

## Test 160

**Expected Tool:** `postgres_database_query`  
**Prompt:** Show me all items that contain the word <search_term> in the PostgreSQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.546308 | `postgres_database_list` | ❌ |
| 2 | 0.523096 | `postgres_database_query` | ✅ **EXPECTED** |
| 3 | 0.503372 | `postgres_table_list` | ❌ |
| 4 | 0.466673 | `postgres_server_list` | ❌ |
| 5 | 0.404026 | `postgres_server_param_get` | ❌ |

---

## Test 161

**Expected Tool:** `postgres_server_config_get`  
**Prompt:** Show me the configuration of PostgreSQL server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.756593 | `postgres_server_config_get` | ✅ **EXPECTED** |
| 2 | 0.615332 | `postgres_server_param_set` | ❌ |
| 3 | 0.599471 | `postgres_server_param_get` | ❌ |
| 4 | 0.534940 | `postgres_database_list` | ❌ |
| 5 | 0.518574 | `postgres_server_list` | ❌ |

---

## Test 162

**Expected Tool:** `postgres_server_list`  
**Prompt:** List all PostgreSQL servers in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.900023 | `postgres_server_list` | ✅ **EXPECTED** |
| 2 | 0.640653 | `postgres_database_list` | ❌ |
| 3 | 0.565914 | `postgres_table_list` | ❌ |
| 4 | 0.538997 | `postgres_server_config_get` | ❌ |
| 5 | 0.534239 | `kusto_cluster_list` | ❌ |

---

## Test 163

**Expected Tool:** `postgres_server_list`  
**Prompt:** Show me my PostgreSQL servers  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.674327 | `postgres_server_list` | ✅ **EXPECTED** |
| 2 | 0.606945 | `postgres_database_list` | ❌ |
| 3 | 0.576348 | `postgres_server_config_get` | ❌ |
| 4 | 0.522995 | `postgres_table_list` | ❌ |
| 5 | 0.506171 | `postgres_server_param_get` | ❌ |

---

## Test 164

**Expected Tool:** `postgres_server_list`  
**Prompt:** Show me the PostgreSQL servers in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.831906 | `postgres_server_list` | ✅ **EXPECTED** |
| 2 | 0.578913 | `postgres_database_list` | ❌ |
| 3 | 0.531848 | `postgres_server_config_get` | ❌ |
| 4 | 0.514248 | `postgres_table_list` | ❌ |
| 5 | 0.505862 | `postgres_server_param_get` | ❌ |

---

## Test 165

**Expected Tool:** `postgres_server_param_get`  
**Prompt:** Show me if the parameter my PostgreSQL server <server> has replication enabled  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.594738 | `postgres_server_param_get` | ✅ **EXPECTED** |
| 2 | 0.552526 | `postgres_server_param_set` | ❌ |
| 3 | 0.539685 | `postgres_server_config_get` | ❌ |
| 4 | 0.489719 | `postgres_server_list` | ❌ |
| 5 | 0.451801 | `postgres_database_list` | ❌ |

---

## Test 166

**Expected Tool:** `postgres_server_param_set`  
**Prompt:** Enable replication for my PostgreSQL server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.579645 | `postgres_server_param_set` | ✅ **EXPECTED** |
| 2 | 0.488474 | `postgres_server_config_get` | ❌ |
| 3 | 0.469794 | `postgres_server_list` | ❌ |
| 4 | 0.447011 | `postgres_server_param_get` | ❌ |
| 5 | 0.440650 | `postgres_database_list` | ❌ |

---

## Test 167

**Expected Tool:** `postgres_table_list`  
**Prompt:** List all tables in the PostgreSQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.789883 | `postgres_table_list` | ✅ **EXPECTED** |
| 2 | 0.750584 | `postgres_database_list` | ❌ |
| 3 | 0.574931 | `postgres_server_list` | ❌ |
| 4 | 0.519911 | `postgres_table_schema_get` | ❌ |
| 5 | 0.501400 | `postgres_server_config_get` | ❌ |

---

## Test 168

**Expected Tool:** `postgres_table_list`  
**Prompt:** Show me the tables in the PostgreSQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.736083 | `postgres_table_list` | ✅ **EXPECTED** |
| 2 | 0.690038 | `postgres_database_list` | ❌ |
| 3 | 0.558436 | `postgres_table_schema_get` | ❌ |
| 4 | 0.543331 | `postgres_server_list` | ❌ |
| 5 | 0.521570 | `postgres_server_config_get` | ❌ |

---

## Test 169

**Expected Tool:** `postgres_table_schema_get`  
**Prompt:** Show me the schema of table <table> in the PostgreSQL database <database> in server <server>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.714917 | `postgres_table_schema_get` | ✅ **EXPECTED** |
| 2 | 0.597846 | `postgres_table_list` | ❌ |
| 3 | 0.574204 | `postgres_database_list` | ❌ |
| 4 | 0.508219 | `kusto_table_schema` | ❌ |
| 5 | 0.508082 | `postgres_server_config_get` | ❌ |

---

## Test 170

**Expected Tool:** `deploy_app_logs_get`  
**Prompt:** Show me the log of the application deployed by azd  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.711806 | `deploy_app_logs_get` | ✅ **EXPECTED** |
| 2 | 0.471692 | `deploy_plan_get` | ❌ |
| 3 | 0.451639 | `monitor_activitylog_list` | ❌ |
| 4 | 0.404891 | `deploy_pipeline_guidance_get` | ❌ |
| 5 | 0.401388 | `monitor_resource_log_query` | ❌ |

---

## Test 171

**Expected Tool:** `deploy_architecture_diagram_generate`  
**Prompt:** Generate the azure architecture diagram for this application  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.680640 | `deploy_architecture_diagram_generate` | ✅ **EXPECTED** |
| 2 | 0.562521 | `deploy_plan_get` | ❌ |
| 3 | 0.497193 | `deploy_pipeline_guidance_get` | ❌ |
| 4 | 0.490198 | `cloudarchitect_design` | ❌ |
| 5 | 0.435923 | `deploy_iac_rules_get` | ❌ |

---

## Test 172

**Expected Tool:** `deploy_iac_rules_get`  
**Prompt:** Show me the rules to generate bicep scripts  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.529160 | `deploy_iac_rules_get` | ✅ **EXPECTED** |
| 2 | 0.479903 | `bicepschema_get` | ❌ |
| 3 | 0.391965 | `get_bestpractices_get` | ❌ |
| 4 | 0.383210 | `azureterraformbestpractices_get` | ❌ |
| 5 | 0.375561 | `extension_cli_generate` | ❌ |

---

## Test 173

**Expected Tool:** `deploy_pipeline_guidance_get`  
**Prompt:** How can I create a CI/CD pipeline to deploy this app to Azure?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.638841 | `deploy_pipeline_guidance_get` | ✅ **EXPECTED** |
| 2 | 0.499242 | `deploy_plan_get` | ❌ |
| 3 | 0.448899 | `deploy_iac_rules_get` | ❌ |
| 4 | 0.385988 | `deploy_app_logs_get` | ❌ |
| 5 | 0.382240 | `get_bestpractices_get` | ❌ |

---

## Test 174

**Expected Tool:** `deploy_plan_get`  
**Prompt:** Create a plan to deploy this application to azure  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.688055 | `deploy_plan_get` | ✅ **EXPECTED** |
| 2 | 0.587903 | `deploy_pipeline_guidance_get` | ❌ |
| 3 | 0.499339 | `deploy_iac_rules_get` | ❌ |
| 4 | 0.498575 | `deploy_architecture_diagram_generate` | ❌ |
| 5 | 0.448692 | `loadtesting_test_create` | ❌ |

---

## Test 175

**Expected Tool:** `eventgrid_events_publish`  
**Prompt:** Publish an event to Event Grid topic <topic_name> using <event_schema> with the following data <event_data>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.756145 | `eventgrid_events_publish` | ✅ **EXPECTED** |
| 2 | 0.483154 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.465986 | `eventgrid_topic_list` | ❌ |
| 4 | 0.360637 | `eventhubs_eventhub_update` | ❌ |
| 5 | 0.355505 | `servicebus_topic_details` | ❌ |

---

## Test 176

**Expected Tool:** `eventgrid_events_publish`  
**Prompt:** Publish event to my Event Grid topic <topic_name> with the following events <event_data>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.655185 | `eventgrid_events_publish` | ✅ **EXPECTED** |
| 2 | 0.524736 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.510038 | `eventgrid_topic_list` | ❌ |
| 4 | 0.373718 | `servicebus_topic_details` | ❌ |
| 5 | 0.359908 | `eventhubs_eventhub_update` | ❌ |

---

## Test 177

**Expected Tool:** `eventgrid_events_publish`  
**Prompt:** Send an event to Event Grid topic <topic_name> in resource group <resource_group_name> with <event_data>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.600646 | `eventgrid_events_publish` | ✅ **EXPECTED** |
| 2 | 0.521267 | `eventgrid_topic_list` | ❌ |
| 3 | 0.504934 | `eventgrid_subscription_list` | ❌ |
| 4 | 0.411096 | `eventhubs_eventhub_consumergroup_update` | ❌ |
| 5 | 0.389418 | `eventhubs_eventhub_consumergroup_get` | ❌ |

---

## Test 178

**Expected Tool:** `eventgrid_topic_list`  
**Prompt:** List all Event Grid topics in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.770140 | `eventgrid_topic_list` | ✅ **EXPECTED** |
| 2 | 0.745542 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.561862 | `kusto_cluster_list` | ❌ |
| 4 | 0.545540 | `search_service_list` | ❌ |
| 5 | 0.526138 | `subscription_list` | ❌ |

---

## Test 179

**Expected Tool:** `eventgrid_topic_list`  
**Prompt:** Show me the Event Grid topics in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.738258 | `eventgrid_topic_list` | ✅ **EXPECTED** |
| 2 | 0.737584 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.492592 | `kusto_cluster_list` | ❌ |
| 4 | 0.480287 | `subscription_list` | ❌ |
| 5 | 0.475119 | `search_service_list` | ❌ |

---

## Test 180

**Expected Tool:** `eventgrid_topic_list`  
**Prompt:** List all Event Grid topics in subscription <subscription>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.770107 | `eventgrid_topic_list` | ✅ **EXPECTED** |
| 2 | 0.721538 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.535468 | `kusto_cluster_list` | ❌ |
| 4 | 0.514376 | `search_service_list` | ❌ |
| 5 | 0.496082 | `subscription_list` | ❌ |

---

## Test 181

**Expected Tool:** `eventgrid_topic_list`  
**Prompt:** List all Event Grid topics in resource group <resource_group_name> in subscription <subscription>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.758816 | `eventgrid_topic_list` | ✅ **EXPECTED** |
| 2 | 0.704479 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.609175 | `group_list` | ❌ |
| 4 | 0.538463 | `monitor_webtests_list` | ❌ |
| 5 | 0.524209 | `eventhubs_namespace_get` | ❌ |

---

## Test 182

**Expected Tool:** `eventgrid_subscription_list`  
**Prompt:** Show me all Event Grid subscriptions for topic <topic_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.769190 | `eventgrid_subscription_list` | ✅ **EXPECTED** |
| 2 | 0.720606 | `eventgrid_topic_list` | ❌ |
| 3 | 0.498615 | `servicebus_topic_details` | ❌ |
| 4 | 0.486983 | `eventgrid_events_publish` | ❌ |
| 5 | 0.486216 | `servicebus_topic_subscription_details` | ❌ |

---

## Test 183

**Expected Tool:** `eventgrid_subscription_list`  
**Prompt:** List Event Grid subscriptions for topic <topic_name> in subscription <subscription>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.718204 | `eventgrid_subscription_list` | ✅ **EXPECTED** |
| 2 | 0.709806 | `eventgrid_topic_list` | ❌ |
| 3 | 0.539977 | `servicebus_topic_subscription_details` | ❌ |
| 4 | 0.529286 | `servicebus_topic_details` | ❌ |
| 5 | 0.478687 | `eventgrid_events_publish` | ❌ |

---

## Test 184

**Expected Tool:** `eventgrid_subscription_list`  
**Prompt:** List Event Grid subscriptions for topic <topic_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.746878 | `eventgrid_subscription_list` | ✅ **EXPECTED** |
| 2 | 0.746174 | `eventgrid_topic_list` | ❌ |
| 3 | 0.529496 | `monitor_webtests_list` | ❌ |
| 4 | 0.524919 | `group_list` | ❌ |
| 5 | 0.503158 | `servicebus_topic_details` | ❌ |

---

## Test 185

**Expected Tool:** `eventgrid_subscription_list`  
**Prompt:** Show all Event Grid subscriptions in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.736508 | `eventgrid_subscription_list` | ✅ **EXPECTED** |
| 2 | 0.659728 | `eventgrid_topic_list` | ❌ |
| 3 | 0.569254 | `subscription_list` | ❌ |
| 4 | 0.537922 | `kusto_cluster_list` | ❌ |
| 5 | 0.518858 | `search_service_list` | ❌ |

---

## Test 186

**Expected Tool:** `eventgrid_subscription_list`  
**Prompt:** List all Event Grid subscriptions in subscription <subscription>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.684620 | `eventgrid_subscription_list` | ✅ **EXPECTED** |
| 2 | 0.656277 | `eventgrid_topic_list` | ❌ |
| 3 | 0.542388 | `subscription_list` | ❌ |
| 4 | 0.521053 | `kusto_cluster_list` | ❌ |
| 5 | 0.510115 | `group_list` | ❌ |

---

## Test 187

**Expected Tool:** `eventgrid_subscription_list`  
**Prompt:** Show Event Grid subscriptions in resource group <resource_group_name> in subscription <subscription>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.697930 | `eventgrid_subscription_list` | ✅ **EXPECTED** |
| 2 | 0.692199 | `eventgrid_topic_list` | ❌ |
| 3 | 0.559238 | `group_list` | ❌ |
| 4 | 0.507789 | `resourcehealth_availability-status_list` | ❌ |
| 5 | 0.506233 | `monitor_webtests_list` | ❌ |

---

## Test 188

**Expected Tool:** `eventgrid_subscription_list`  
**Prompt:** List Event Grid subscriptions for subscription <subscription> in location <location>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.710068 | `eventgrid_subscription_list` | ✅ **EXPECTED** |
| 2 | 0.642500 | `eventgrid_topic_list` | ❌ |
| 3 | 0.506868 | `subscription_list` | ❌ |
| 4 | 0.476756 | `search_service_list` | ❌ |
| 5 | 0.475826 | `kusto_cluster_list` | ❌ |

---

## Test 189

**Expected Tool:** `eventhubs_eventhub_consumergroup_delete`  
**Prompt:** Delete my consumer group <consumer_group_name> in my event hub <event_hub_name>, namespace <namespace_name>, and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.766955 | `eventhubs_eventhub_consumergroup_delete` | ✅ **EXPECTED** |
| 2 | 0.675857 | `eventhubs_eventhub_consumergroup_update` | ❌ |
| 3 | 0.641133 | `eventhubs_eventhub_consumergroup_get` | ❌ |
| 4 | 0.633862 | `eventhubs_namespace_delete` | ❌ |
| 5 | 0.605646 | `eventhubs_eventhub_delete` | ❌ |

---

## Test 190

**Expected Tool:** `eventhubs_eventhub_consumergroup_get`  
**Prompt:** List all consumer groups in my event hub <event_hub_name> in namespace <namespace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.738416 | `eventhubs_eventhub_consumergroup_get` | ✅ **EXPECTED** |
| 2 | 0.634517 | `eventhubs_eventhub_consumergroup_update` | ❌ |
| 3 | 0.626486 | `eventhubs_eventhub_consumergroup_delete` | ❌ |
| 4 | 0.606619 | `eventhubs_namespace_get` | ❌ |
| 5 | 0.593098 | `eventhubs_eventhub_get` | ❌ |

---

## Test 191

**Expected Tool:** `eventhubs_eventhub_consumergroup_get`  
**Prompt:** Get the details of my consumer group <consumer_group_name> in my event hub <event_hub_name>, namespace <namespace_name>, and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.712899 | `eventhubs_eventhub_consumergroup_get` | ✅ **EXPECTED** |
| 2 | 0.637170 | `eventhubs_eventhub_consumergroup_update` | ❌ |
| 3 | 0.625913 | `eventhubs_eventhub_consumergroup_delete` | ❌ |
| 4 | 0.576800 | `eventhubs_namespace_get` | ❌ |
| 5 | 0.529940 | `eventhubs_eventhub_get` | ❌ |

---

## Test 192

**Expected Tool:** `eventhubs_eventhub_consumergroup_update`  
**Prompt:** Create a new consumer group <consumer_group_name> in my event hub <event_hub_name>, namespace <namespace_name>, and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.757614 | `eventhubs_eventhub_consumergroup_update` | ✅ **EXPECTED** |
| 2 | 0.688895 | `eventhubs_eventhub_consumergroup_get` | ❌ |
| 3 | 0.670026 | `eventhubs_eventhub_consumergroup_delete` | ❌ |
| 4 | 0.554315 | `eventhubs_eventhub_update` | ❌ |
| 5 | 0.545003 | `eventhubs_namespace_get` | ❌ |

---

## Test 193

**Expected Tool:** `eventhubs_eventhub_consumergroup_update`  
**Prompt:** Update my consumer group <consumer_group_name> in my event hub <event_hub_name>, namespace <namespace_name>, and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.738818 | `eventhubs_eventhub_consumergroup_update` | ✅ **EXPECTED** |
| 2 | 0.655614 | `eventhubs_eventhub_consumergroup_delete` | ❌ |
| 3 | 0.642209 | `eventhubs_eventhub_consumergroup_get` | ❌ |
| 4 | 0.552234 | `eventhubs_eventhub_update` | ❌ |
| 5 | 0.524019 | `eventhubs_namespace_delete` | ❌ |

---

## Test 194

**Expected Tool:** `eventhubs_eventhub_delete`  
**Prompt:** Delete my event hub <event_hub_name> in my namespace <namespace_name> and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.699140 | `eventhubs_namespace_delete` | ❌ |
| 2 | 0.688378 | `eventhubs_eventhub_delete` | ✅ **EXPECTED** |
| 3 | 0.627664 | `eventhubs_eventhub_consumergroup_delete` | ❌ |
| 4 | 0.578625 | `eventhubs_namespace_get` | ❌ |
| 5 | 0.552861 | `eventhubs_eventhub_get` | ❌ |

---

## Test 195

**Expected Tool:** `eventhubs_eventhub_get`  
**Prompt:** List all Event Hubs in my namespace <namespace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.773242 | `eventhubs_eventhub_get` | ✅ **EXPECTED** |
| 2 | 0.687582 | `eventhubs_namespace_get` | ❌ |
| 3 | 0.578689 | `eventhubs_eventhub_update` | ❌ |
| 4 | 0.561544 | `eventhubs_namespace_delete` | ❌ |
| 5 | 0.545548 | `eventhubs_eventhub_consumergroup_get` | ❌ |

---

## Test 196

**Expected Tool:** `eventhubs_eventhub_get`  
**Prompt:** Get the details of my event hub <event_hub_name> in my namespace <namespace_name> and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.637789 | `eventhubs_namespace_get` | ❌ |
| 2 | 0.627263 | `eventhubs_eventhub_get` | ✅ **EXPECTED** |
| 3 | 0.570838 | `eventhubs_eventhub_consumergroup_get` | ❌ |
| 4 | 0.527270 | `eventhubs_eventhub_update` | ❌ |
| 5 | 0.521764 | `eventhubs_namespace_delete` | ❌ |

---

## Test 197

**Expected Tool:** `eventhubs_eventhub_update`  
**Prompt:** Create a new event hub <event_hub_name> in my namespace <namespace_name> and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.646041 | `eventhubs_eventhub_update` | ✅ **EXPECTED** |
| 2 | 0.605976 | `eventhubs_namespace_get` | ❌ |
| 3 | 0.574459 | `eventhubs_eventhub_get` | ❌ |
| 4 | 0.571753 | `eventhubs_eventhub_consumergroup_update` | ❌ |
| 5 | 0.557600 | `eventhubs_namespace_delete` | ❌ |

---

## Test 198

**Expected Tool:** `eventhubs_eventhub_update`  
**Prompt:** Update my event hub <event_hub_name> in my namespace <namespace_name> and resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.655275 | `eventhubs_eventhub_update` | ✅ **EXPECTED** |
| 2 | 0.571562 | `eventhubs_eventhub_delete` | ❌ |
| 3 | 0.568872 | `eventhubs_eventhub_consumergroup_update` | ❌ |
| 4 | 0.568604 | `eventhubs_namespace_get` | ❌ |
| 5 | 0.566081 | `eventhubs_namespace_delete` | ❌ |

---

## Test 199

**Expected Tool:** `eventhubs_namespace_delete`  
**Prompt:** Delete my namespace <namespace_name> in my resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.623995 | `eventhubs_namespace_delete` | ✅ **EXPECTED** |
| 2 | 0.525446 | `eventhubs_namespace_update` | ❌ |
| 3 | 0.505082 | `eventhubs_eventhub_consumergroup_delete` | ❌ |
| 4 | 0.449841 | `eventhubs_namespace_get` | ❌ |
| 5 | 0.435037 | `workbooks_delete` | ❌ |

---

## Test 200

**Expected Tool:** `eventhubs_namespace_get`  
**Prompt:** List all Event Hubs namespaces in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.659838 | `eventhubs_eventhub_get` | ❌ |
| 2 | 0.658827 | `eventhubs_namespace_get` | ✅ **EXPECTED** |
| 3 | 0.607372 | `kusto_cluster_list` | ❌ |
| 4 | 0.557200 | `eventgrid_topic_list` | ❌ |
| 5 | 0.556163 | `eventgrid_subscription_list` | ❌ |

---

## Test 201

**Expected Tool:** `eventhubs_namespace_get`  
**Prompt:** Get the details of my namespace <namespace_name> in my resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.510014 | `monitor_webtests_get` | ❌ |
| 2 | 0.509727 | `eventhubs_namespace_get` | ✅ **EXPECTED** |
| 3 | 0.497387 | `servicebus_queue_details` | ❌ |
| 4 | 0.490094 | `eventhubs_namespace_update` | ❌ |
| 5 | 0.470410 | `functionapp_get` | ❌ |

---

## Test 202

**Expected Tool:** `eventhubs_namespace_update`  
**Prompt:** Create an new namespace <namespace_name> in my resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.610331 | `eventhubs_namespace_update` | ✅ **EXPECTED** |
| 2 | 0.466715 | `eventhubs_namespace_get` | ❌ |
| 3 | 0.458479 | `eventhubs_namespace_delete` | ❌ |
| 4 | 0.449608 | `workbooks_create` | ❌ |
| 5 | 0.438423 | `eventhubs_eventhub_consumergroup_update` | ❌ |

---

## Test 203

**Expected Tool:** `eventhubs_namespace_update`  
**Prompt:** Update my namespace <namespace_name> in my resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.622338 | `eventhubs_namespace_update` | ✅ **EXPECTED** |
| 2 | 0.474098 | `eventhubs_namespace_delete` | ❌ |
| 3 | 0.448723 | `eventhubs_namespace_get` | ❌ |
| 4 | 0.436549 | `eventhubs_eventhub_consumergroup_update` | ❌ |
| 5 | 0.372632 | `sql_db_rename` | ❌ |

---

## Test 204

**Expected Tool:** `functionapp_get`  
**Prompt:** Describe the function app <function_app_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.660116 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.451752 | `deploy_app_logs_get` | ❌ |
| 3 | 0.450457 | `applens_resource_diagnose` | ❌ |
| 4 | 0.390048 | `mysql_server_list` | ❌ |
| 5 | 0.380314 | `get_bestpractices_get` | ❌ |

---

## Test 205

**Expected Tool:** `functionapp_get`  
**Prompt:** Get configuration for function app <function_app_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.607276 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.447400 | `mysql_server_config_get` | ❌ |
| 3 | 0.424693 | `appconfig_account_list` | ❌ |
| 4 | 0.411267 | `appconfig_kv_get` | ❌ |
| 5 | 0.400444 | `deploy_app_logs_get` | ❌ |

---

## Test 206

**Expected Tool:** `functionapp_get`  
**Prompt:** Get function app status for <function_app_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.622384 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.413481 | `resourcehealth_availability-status_get` | ❌ |
| 3 | 0.390728 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.383665 | `deploy_app_logs_get` | ❌ |
| 5 | 0.360665 | `storage_account_get` | ❌ |

---

## Test 207

**Expected Tool:** `functionapp_get`  
**Prompt:** Get information about my function app <function_app_name> in <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.690933 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.441934 | `foundry_resource_get` | ❌ |
| 3 | 0.432383 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.431821 | `applens_resource_diagnose` | ❌ |
| 5 | 0.429077 | `storage_account_get` | ❌ |

---

## Test 208

**Expected Tool:** `functionapp_get`  
**Prompt:** Retrieve host name and status of function app <function_app_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.592791 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.417817 | `resourcehealth_availability-status_get` | ❌ |
| 3 | 0.409836 | `deploy_app_logs_get` | ❌ |
| 4 | 0.399953 | `storage_account_get` | ❌ |
| 5 | 0.392237 | `applens_resource_diagnose` | ❌ |

---

## Test 209

**Expected Tool:** `functionapp_get`  
**Prompt:** Show function app details for <function_app_name> in <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.687356 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.449635 | `deploy_app_logs_get` | ❌ |
| 3 | 0.428689 | `applens_resource_diagnose` | ❌ |
| 4 | 0.424648 | `foundry_resource_get` | ❌ |
| 5 | 0.392339 | `monitor_webtests_get` | ❌ |

---

## Test 210

**Expected Tool:** `functionapp_get`  
**Prompt:** Show me the details for the function app <function_app_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.644882 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.430266 | `deploy_app_logs_get` | ❌ |
| 3 | 0.421082 | `storage_account_get` | ❌ |
| 4 | 0.403311 | `signalr_runtime_get` | ❌ |
| 5 | 0.391545 | `foundry_resource_get` | ❌ |

---

## Test 211

**Expected Tool:** `functionapp_get`  
**Prompt:** Show plan and region for function app <function_app_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.554980 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.426703 | `quota_usage_check` | ❌ |
| 3 | 0.424631 | `deploy_app_logs_get` | ❌ |
| 4 | 0.408011 | `deploy_plan_get` | ❌ |
| 5 | 0.381629 | `deploy_architecture_diagram_generate` | ❌ |

---

## Test 212

**Expected Tool:** `functionapp_get`  
**Prompt:** What is the status of function app <function_app_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.565797 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.403811 | `deploy_app_logs_get` | ❌ |
| 3 | 0.384163 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.369868 | `applens_resource_diagnose` | ❌ |
| 5 | 0.355044 | `resourcehealth_availability-status_get` | ❌ |

---

## Test 213

**Expected Tool:** `functionapp_get`  
**Prompt:** List all function apps in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.646561 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.559382 | `search_service_list` | ❌ |
| 3 | 0.534930 | `subscription_list` | ❌ |
| 4 | 0.529031 | `kusto_cluster_list` | ❌ |
| 5 | 0.516618 | `cosmos_account_list` | ❌ |

---

## Test 214

**Expected Tool:** `functionapp_get`  
**Prompt:** Show me my Azure function apps  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.560249 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.465065 | `deploy_app_logs_get` | ❌ |
| 3 | 0.412646 | `search_service_list` | ❌ |
| 4 | 0.411323 | `get_bestpractices_get` | ❌ |
| 5 | 0.398503 | `extension_cli_install` | ❌ |

---

## Test 215

**Expected Tool:** `functionapp_get`  
**Prompt:** What function apps do I have?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.433675 | `functionapp_get` | ✅ **EXPECTED** |
| 2 | 0.346657 | `deploy_app_logs_get` | ❌ |
| 3 | 0.337966 | `applens_resource_diagnose` | ❌ |
| 4 | 0.316594 | `extension_cli_install` | ❌ |
| 5 | 0.284362 | `get_bestpractices_get` | ❌ |

---

## Test 216

**Expected Tool:** `keyvault_admin_settings_get`  
**Prompt:** Get the account settings for my key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.604780 | `keyvault_admin_settings_get` | ✅ **EXPECTED** |
| 2 | 0.532196 | `storage_account_get` | ❌ |
| 3 | 0.496629 | `keyvault_key_get` | ❌ |
| 4 | 0.452187 | `appconfig_kv_set` | ❌ |
| 5 | 0.448039 | `keyvault_secret_get` | ❌ |

---

## Test 217

**Expected Tool:** `keyvault_admin_settings_get`  
**Prompt:** Show me the account settings for managed HSM keyvault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.671370 | `keyvault_admin_settings_get` | ✅ **EXPECTED** |
| 2 | 0.455561 | `storage_account_get` | ❌ |
| 3 | 0.441224 | `keyvault_key_get` | ❌ |
| 4 | 0.404536 | `appconfig_kv_set` | ❌ |
| 5 | 0.395274 | `keyvault_secret_get` | ❌ |

---

## Test 218

**Expected Tool:** `keyvault_admin_settings_get`  
**Prompt:** What's the value of the <setting_name> setting in my key vault with name <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.505750 | `keyvault_admin_settings_get` | ✅ **EXPECTED** |
| 2 | 0.496386 | `appconfig_kv_set` | ❌ |
| 3 | 0.420145 | `appconfig_kv_lock_set` | ❌ |
| 4 | 0.419126 | `keyvault_key_get` | ❌ |
| 5 | 0.410215 | `keyvault_secret_get` | ❌ |

---

## Test 219

**Expected Tool:** `keyvault_certificate_create`  
**Prompt:** Create a new certificate called <certificate_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.627727 | `keyvault_certificate_create` | ✅ **EXPECTED** |
| 2 | 0.570319 | `keyvault_certificate_import` | ❌ |
| 3 | 0.540199 | `keyvault_key_create` | ❌ |
| 4 | 0.516779 | `keyvault_certificate_get` | ❌ |
| 5 | 0.500129 | `keyvault_certificate_list` | ❌ |

---

## Test 220

**Expected Tool:** `keyvault_certificate_create`  
**Prompt:** Generate a certificate named <certificate_name> in key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.599990 | `keyvault_certificate_create` | ✅ **EXPECTED** |
| 2 | 0.561445 | `keyvault_certificate_import` | ❌ |
| 3 | 0.520513 | `keyvault_certificate_get` | ❌ |
| 4 | 0.502128 | `keyvault_key_create` | ❌ |
| 5 | 0.497258 | `keyvault_certificate_list` | ❌ |

---

## Test 221

**Expected Tool:** `keyvault_certificate_create`  
**Prompt:** Request creation of certificate <certificate_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.573998 | `keyvault_certificate_create` | ✅ **EXPECTED** |
| 2 | 0.527759 | `keyvault_certificate_import` | ❌ |
| 3 | 0.496174 | `keyvault_certificate_get` | ❌ |
| 4 | 0.481548 | `keyvault_key_create` | ❌ |
| 5 | 0.469738 | `keyvault_certificate_list` | ❌ |

---

## Test 222

**Expected Tool:** `keyvault_certificate_create`  
**Prompt:** Provision a new key vault certificate <certificate_name> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.591792 | `keyvault_certificate_create` | ✅ **EXPECTED** |
| 2 | 0.562252 | `keyvault_certificate_import` | ❌ |
| 3 | 0.519707 | `keyvault_certificate_get` | ❌ |
| 4 | 0.502613 | `keyvault_key_create` | ❌ |
| 5 | 0.480111 | `keyvault_certificate_list` | ❌ |

---

## Test 223

**Expected Tool:** `keyvault_certificate_create`  
**Prompt:** Issue a certificate <certificate_name> in key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.622788 | `keyvault_certificate_create` | ✅ **EXPECTED** |
| 2 | 0.558532 | `keyvault_certificate_import` | ❌ |
| 3 | 0.532447 | `keyvault_certificate_get` | ❌ |
| 4 | 0.521446 | `keyvault_certificate_list` | ❌ |
| 5 | 0.465056 | `keyvault_key_create` | ❌ |

---

## Test 224

**Expected Tool:** `keyvault_certificate_get`  
**Prompt:** Show me the certificate <certificate_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.603920 | `keyvault_certificate_get` | ✅ **EXPECTED** |
| 2 | 0.528535 | `keyvault_certificate_list` | ❌ |
| 3 | 0.519037 | `keyvault_certificate_import` | ❌ |
| 4 | 0.499293 | `keyvault_certificate_create` | ❌ |
| 5 | 0.486608 | `keyvault_key_get` | ❌ |

---

## Test 225

**Expected Tool:** `keyvault_certificate_get`  
**Prompt:** Show me the details of the certificate <certificate_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.649497 | `keyvault_certificate_get` | ✅ **EXPECTED** |
| 2 | 0.563189 | `keyvault_key_get` | ❌ |
| 3 | 0.514122 | `keyvault_secret_get` | ❌ |
| 4 | 0.509448 | `keyvault_certificate_list` | ❌ |
| 5 | 0.507813 | `keyvault_certificate_import` | ❌ |

---

## Test 226

**Expected Tool:** `keyvault_certificate_get`  
**Prompt:** Get the certificate <certificate_name> from vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.607762 | `keyvault_certificate_get` | ✅ **EXPECTED** |
| 2 | 0.515675 | `keyvault_certificate_list` | ❌ |
| 3 | 0.511197 | `keyvault_certificate_create` | ❌ |
| 4 | 0.507768 | `keyvault_certificate_import` | ❌ |
| 5 | 0.474394 | `keyvault_key_get` | ❌ |

---

## Test 227

**Expected Tool:** `keyvault_certificate_get`  
**Prompt:** Display the certificate details for <certificate_name> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.650259 | `keyvault_certificate_get` | ✅ **EXPECTED** |
| 2 | 0.527400 | `keyvault_key_get` | ❌ |
| 3 | 0.521676 | `keyvault_certificate_list` | ❌ |
| 4 | 0.509796 | `keyvault_certificate_import` | ❌ |
| 5 | 0.501988 | `keyvault_secret_get` | ❌ |

---

## Test 228

**Expected Tool:** `keyvault_certificate_get`  
**Prompt:** Retrieve certificate metadata for <certificate_name> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.594757 | `keyvault_certificate_get` | ✅ **EXPECTED** |
| 2 | 0.527522 | `keyvault_certificate_list` | ❌ |
| 3 | 0.519059 | `keyvault_certificate_import` | ❌ |
| 4 | 0.501138 | `keyvault_certificate_create` | ❌ |
| 5 | 0.465174 | `keyvault_key_get` | ❌ |

---

## Test 229

**Expected Tool:** `keyvault_certificate_import`  
**Prompt:** Import the certificate in file <file_path> into the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.585481 | `keyvault_certificate_import` | ✅ **EXPECTED** |
| 2 | 0.420513 | `keyvault_certificate_get` | ❌ |
| 3 | 0.402595 | `keyvault_certificate_create` | ❌ |
| 4 | 0.399457 | `keyvault_certificate_list` | ❌ |
| 5 | 0.352905 | `keyvault_key_create` | ❌ |

---

## Test 230

**Expected Tool:** `keyvault_certificate_import`  
**Prompt:** Import a certificate into the key vault <key_vault_account_name> using the name <certificate_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.622125 | `keyvault_certificate_import` | ✅ **EXPECTED** |
| 2 | 0.502519 | `keyvault_certificate_get` | ❌ |
| 3 | 0.498847 | `keyvault_certificate_create` | ❌ |
| 4 | 0.448248 | `keyvault_certificate_list` | ❌ |
| 5 | 0.419811 | `keyvault_key_create` | ❌ |

---

## Test 231

**Expected Tool:** `keyvault_certificate_import`  
**Prompt:** Upload certificate file <file_path> to key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.595610 | `keyvault_certificate_import` | ✅ **EXPECTED** |
| 2 | 0.453832 | `keyvault_certificate_create` | ❌ |
| 3 | 0.452229 | `keyvault_certificate_get` | ❌ |
| 4 | 0.418208 | `keyvault_certificate_list` | ❌ |
| 5 | 0.413349 | `keyvault_key_create` | ❌ |

---

## Test 232

**Expected Tool:** `keyvault_certificate_import`  
**Prompt:** Load certificate <certificate_name> from file <file_path> into vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.619480 | `keyvault_certificate_import` | ✅ **EXPECTED** |
| 2 | 0.516553 | `keyvault_certificate_get` | ❌ |
| 3 | 0.480815 | `keyvault_certificate_create` | ❌ |
| 4 | 0.444497 | `keyvault_certificate_list` | ❌ |
| 5 | 0.381873 | `keyvault_key_create` | ❌ |

---

## Test 233

**Expected Tool:** `keyvault_certificate_import`  
**Prompt:** Add existing certificate file <file_path> to the key vault <key_vault_account_name> with name <certificate_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.595418 | `keyvault_certificate_import` | ✅ **EXPECTED** |
| 2 | 0.452490 | `keyvault_certificate_create` | ❌ |
| 3 | 0.441034 | `keyvault_certificate_get` | ❌ |
| 4 | 0.408018 | `keyvault_key_create` | ❌ |
| 5 | 0.392244 | `keyvault_secret_create` | ❌ |

---

## Test 234

**Expected Tool:** `keyvault_certificate_list`  
**Prompt:** List all certificates in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.726229 | `keyvault_certificate_list` | ✅ **EXPECTED** |
| 2 | 0.583009 | `keyvault_key_list` | ❌ |
| 3 | 0.531988 | `keyvault_secret_list` | ❌ |
| 4 | 0.514728 | `keyvault_certificate_get` | ❌ |
| 5 | 0.485792 | `keyvault_certificate_create` | ❌ |

---

## Test 235

**Expected Tool:** `keyvault_certificate_list`  
**Prompt:** Show me the certificates in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.615666 | `keyvault_certificate_list` | ✅ **EXPECTED** |
| 2 | 0.525575 | `keyvault_certificate_get` | ❌ |
| 3 | 0.475081 | `keyvault_key_list` | ❌ |
| 4 | 0.460973 | `keyvault_certificate_create` | ❌ |
| 5 | 0.448139 | `keyvault_key_get` | ❌ |

---

## Test 236

**Expected Tool:** `keyvault_certificate_list`  
**Prompt:** What certificates are in the key vault <key_vault_account_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.624837 | `keyvault_certificate_list` | ✅ **EXPECTED** |
| 2 | 0.519199 | `keyvault_certificate_get` | ❌ |
| 3 | 0.510048 | `keyvault_certificate_create` | ❌ |
| 4 | 0.505534 | `keyvault_certificate_import` | ❌ |
| 5 | 0.497252 | `keyvault_key_list` | ❌ |

---

## Test 237

**Expected Tool:** `keyvault_certificate_list`  
**Prompt:** List certificate names in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.672741 | `keyvault_certificate_list` | ✅ **EXPECTED** |
| 2 | 0.553881 | `keyvault_key_list` | ❌ |
| 3 | 0.511905 | `keyvault_secret_list` | ❌ |
| 4 | 0.506122 | `keyvault_certificate_get` | ❌ |
| 5 | 0.492357 | `keyvault_certificate_create` | ❌ |

---

## Test 238

**Expected Tool:** `keyvault_certificate_list`  
**Prompt:** Enumerate certificates in key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.747445 | `keyvault_certificate_list` | ✅ **EXPECTED** |
| 2 | 0.594130 | `keyvault_key_list` | ❌ |
| 3 | 0.558771 | `keyvault_secret_list` | ❌ |
| 4 | 0.514215 | `keyvault_certificate_get` | ❌ |
| 5 | 0.490876 | `keyvault_certificate_create` | ❌ |

---

## Test 239

**Expected Tool:** `keyvault_certificate_list`  
**Prompt:** Show certificate names in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.639847 | `keyvault_certificate_list` | ✅ **EXPECTED** |
| 2 | 0.512927 | `keyvault_certificate_get` | ❌ |
| 3 | 0.507469 | `keyvault_key_list` | ❌ |
| 4 | 0.482583 | `keyvault_certificate_create` | ❌ |
| 5 | 0.464725 | `keyvault_secret_list` | ❌ |

---

## Test 240

**Expected Tool:** `keyvault_key_create`  
**Prompt:** Create a new key called <key_name> with the RSA type in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.661466 | `keyvault_key_create` | ✅ **EXPECTED** |
| 2 | 0.456580 | `keyvault_secret_create` | ❌ |
| 3 | 0.451790 | `keyvault_certificate_create` | ❌ |
| 4 | 0.429614 | `keyvault_certificate_import` | ❌ |
| 5 | 0.399326 | `keyvault_key_get` | ❌ |

---

## Test 241

**Expected Tool:** `keyvault_key_create`  
**Prompt:** Generate a key <key_name> with type <key_type> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.641070 | `keyvault_key_create` | ✅ **EXPECTED** |
| 2 | 0.428502 | `keyvault_key_get` | ❌ |
| 3 | 0.422763 | `keyvault_certificate_create` | ❌ |
| 4 | 0.420045 | `keyvault_secret_create` | ❌ |
| 5 | 0.405382 | `appconfig_kv_set` | ❌ |

---

## Test 242

**Expected Tool:** `keyvault_key_create`  
**Prompt:** Create an oct key in the vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.547493 | `keyvault_key_create` | ✅ **EXPECTED** |
| 2 | 0.463557 | `keyvault_secret_create` | ❌ |
| 3 | 0.447410 | `keyvault_certificate_create` | ❌ |
| 4 | 0.420366 | `keyvault_key_get` | ❌ |
| 5 | 0.404350 | `keyvault_certificate_import` | ❌ |

---

## Test 243

**Expected Tool:** `keyvault_key_create`  
**Prompt:** Create an RSA key in the vault <key_vault_account_name> with name <key_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.641493 | `keyvault_key_create` | ✅ **EXPECTED** |
| 2 | 0.501728 | `keyvault_secret_create` | ❌ |
| 3 | 0.491798 | `keyvault_certificate_create` | ❌ |
| 4 | 0.464624 | `keyvault_certificate_import` | ❌ |
| 5 | 0.451075 | `keyvault_key_get` | ❌ |

---

## Test 244

**Expected Tool:** `keyvault_key_create`  
**Prompt:** Create an EC key with name <key_name> in the vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.571775 | `keyvault_key_create` | ✅ **EXPECTED** |
| 2 | 0.443414 | `keyvault_certificate_create` | ❌ |
| 3 | 0.434720 | `keyvault_secret_create` | ❌ |
| 4 | 0.421643 | `keyvault_key_get` | ❌ |
| 5 | 0.400585 | `keyvault_certificate_import` | ❌ |

---

## Test 245

**Expected Tool:** `keyvault_key_get`  
**Prompt:** Show me the key <key_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.549488 | `keyvault_key_get` | ✅ **EXPECTED** |
| 2 | 0.468165 | `keyvault_secret_get` | ❌ |
| 3 | 0.452816 | `keyvault_key_create` | ❌ |
| 4 | 0.439889 | `keyvault_key_list` | ❌ |
| 5 | 0.430276 | `keyvault_certificate_get` | ❌ |

---

## Test 246

**Expected Tool:** `keyvault_key_get`  
**Prompt:** Show me the details of the key <key_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.629552 | `keyvault_key_get` | ✅ **EXPECTED** |
| 2 | 0.532651 | `keyvault_secret_get` | ❌ |
| 3 | 0.512278 | `storage_account_get` | ❌ |
| 4 | 0.499651 | `keyvault_certificate_get` | ❌ |
| 5 | 0.456992 | `keyvault_key_create` | ❌ |

---

## Test 247

**Expected Tool:** `keyvault_key_get`  
**Prompt:** Get the key <key_name> from vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.484645 | `keyvault_key_get` | ✅ **EXPECTED** |
| 2 | 0.443182 | `keyvault_key_create` | ❌ |
| 3 | 0.409388 | `keyvault_secret_get` | ❌ |
| 4 | 0.395491 | `keyvault_admin_settings_get` | ❌ |
| 5 | 0.383519 | `appconfig_kv_lock_set` | ❌ |

---

## Test 248

**Expected Tool:** `keyvault_key_get`  
**Prompt:** Display the key details for <key_name> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.590303 | `keyvault_key_get` | ✅ **EXPECTED** |
| 2 | 0.488213 | `keyvault_secret_get` | ❌ |
| 3 | 0.476498 | `storage_account_get` | ❌ |
| 4 | 0.464194 | `keyvault_certificate_get` | ❌ |
| 5 | 0.436511 | `keyvault_admin_settings_get` | ❌ |

---

## Test 249

**Expected Tool:** `keyvault_key_get`  
**Prompt:** Retrieve key metadata for <key_name> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.518663 | `keyvault_key_get` | ✅ **EXPECTED** |
| 2 | 0.433151 | `storage_account_get` | ❌ |
| 3 | 0.432727 | `keyvault_admin_settings_get` | ❌ |
| 4 | 0.428992 | `keyvault_key_create` | ❌ |
| 5 | 0.422355 | `keyvault_secret_get` | ❌ |

---

## Test 250

**Expected Tool:** `keyvault_key_list`  
**Prompt:** List all keys in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.701335 | `keyvault_key_list` | ✅ **EXPECTED** |
| 2 | 0.601663 | `keyvault_certificate_list` | ❌ |
| 3 | 0.587427 | `keyvault_secret_list` | ❌ |
| 4 | 0.498767 | `cosmos_account_list` | ❌ |
| 5 | 0.480129 | `keyvault_admin_settings_get` | ❌ |

---

## Test 251

**Expected Tool:** `keyvault_key_list`  
**Prompt:** Show me the keys in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.549377 | `keyvault_key_list` | ✅ **EXPECTED** |
| 2 | 0.506815 | `keyvault_key_get` | ❌ |
| 3 | 0.475662 | `keyvault_certificate_list` | ❌ |
| 4 | 0.472465 | `keyvault_admin_settings_get` | ❌ |
| 5 | 0.455683 | `keyvault_secret_get` | ❌ |

---

## Test 252

**Expected Tool:** `keyvault_key_list`  
**Prompt:** What keys are in the key vault <key_vault_account_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.581864 | `keyvault_key_list` | ✅ **EXPECTED** |
| 2 | 0.502245 | `keyvault_admin_settings_get` | ❌ |
| 3 | 0.501644 | `keyvault_certificate_list` | ❌ |
| 4 | 0.476470 | `keyvault_key_get` | ❌ |
| 5 | 0.472414 | `keyvault_secret_list` | ❌ |

---

## Test 253

**Expected Tool:** `keyvault_key_list`  
**Prompt:** List key names in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.641190 | `keyvault_key_list` | ✅ **EXPECTED** |
| 2 | 0.559685 | `keyvault_certificate_list` | ❌ |
| 3 | 0.553553 | `keyvault_secret_list` | ❌ |
| 4 | 0.486377 | `keyvault_admin_settings_get` | ❌ |
| 5 | 0.475992 | `cosmos_account_list` | ❌ |

---

## Test 254

**Expected Tool:** `keyvault_key_list`  
**Prompt:** Enumerate keys in key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.723169 | `keyvault_key_list` | ✅ **EXPECTED** |
| 2 | 0.611443 | `keyvault_certificate_list` | ❌ |
| 3 | 0.611185 | `keyvault_secret_list` | ❌ |
| 4 | 0.473886 | `keyvault_admin_settings_get` | ❌ |
| 5 | 0.441881 | `keyvault_key_get` | ❌ |

---

## Test 255

**Expected Tool:** `keyvault_key_list`  
**Prompt:** Show key names in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.570333 | `keyvault_key_list` | ✅ **EXPECTED** |
| 2 | 0.501073 | `keyvault_key_get` | ❌ |
| 3 | 0.500272 | `keyvault_certificate_list` | ❌ |
| 4 | 0.496817 | `storage_account_get` | ❌ |
| 5 | 0.490367 | `keyvault_secret_list` | ❌ |

---

## Test 256

**Expected Tool:** `keyvault_secret_create`  
**Prompt:** Create a new secret called <secret_name> with value <secret_value> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.676757 | `keyvault_secret_create` | ✅ **EXPECTED** |
| 2 | 0.547317 | `keyvault_key_create` | ❌ |
| 3 | 0.514159 | `keyvault_secret_get` | ❌ |
| 4 | 0.469621 | `keyvault_certificate_create` | ❌ |
| 5 | 0.457172 | `appconfig_kv_set` | ❌ |

---

## Test 257

**Expected Tool:** `keyvault_secret_create`  
**Prompt:** Set a secret named <secret_name> with value <secret_value> in key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.663094 | `keyvault_secret_create` | ✅ **EXPECTED** |
| 2 | 0.519601 | `keyvault_secret_get` | ❌ |
| 3 | 0.512090 | `appconfig_kv_set` | ❌ |
| 4 | 0.458502 | `keyvault_key_create` | ❌ |
| 5 | 0.429785 | `appconfig_kv_lock_set` | ❌ |

---

## Test 258

**Expected Tool:** `keyvault_secret_create`  
**Prompt:** Store secret <secret_name> value <secret_value> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.640646 | `keyvault_secret_create` | ✅ **EXPECTED** |
| 2 | 0.510298 | `keyvault_secret_get` | ❌ |
| 3 | 0.485221 | `keyvault_key_create` | ❌ |
| 4 | 0.484962 | `appconfig_kv_set` | ❌ |
| 5 | 0.448502 | `appconfig_kv_lock_set` | ❌ |

---

## Test 259

**Expected Tool:** `keyvault_secret_create`  
**Prompt:** Add a new version of secret <secret_name> with value <secret_value> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.675248 | `keyvault_secret_create` | ✅ **EXPECTED** |
| 2 | 0.499471 | `keyvault_secret_get` | ❌ |
| 3 | 0.498387 | `keyvault_key_create` | ❌ |
| 4 | 0.478928 | `keyvault_certificate_import` | ❌ |
| 5 | 0.458406 | `appconfig_kv_set` | ❌ |

---

## Test 260

**Expected Tool:** `keyvault_secret_create`  
**Prompt:** Update secret <secret_name> to value <secret_value> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.571612 | `keyvault_secret_create` | ✅ **EXPECTED** |
| 2 | 0.513767 | `keyvault_secret_get` | ❌ |
| 3 | 0.441019 | `appconfig_kv_set` | ❌ |
| 4 | 0.417943 | `appconfig_kv_lock_set` | ❌ |
| 5 | 0.408242 | `keyvault_key_get` | ❌ |

---

## Test 261

**Expected Tool:** `keyvault_secret_get`  
**Prompt:** Show me the secret <secret_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.602769 | `keyvault_secret_get` | ✅ **EXPECTED** |
| 2 | 0.504212 | `keyvault_key_get` | ❌ |
| 3 | 0.501397 | `keyvault_secret_create` | ❌ |
| 4 | 0.478769 | `keyvault_secret_list` | ❌ |
| 5 | 0.442344 | `keyvault_certificate_get` | ❌ |

---

## Test 262

**Expected Tool:** `keyvault_secret_get`  
**Prompt:** Show me the details of the secret <secret_name> in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.654059 | `keyvault_secret_get` | ✅ **EXPECTED** |
| 2 | 0.566876 | `keyvault_key_get` | ❌ |
| 3 | 0.517384 | `storage_account_get` | ❌ |
| 4 | 0.499044 | `keyvault_certificate_get` | ❌ |
| 5 | 0.485350 | `keyvault_secret_list` | ❌ |

---

## Test 263

**Expected Tool:** `keyvault_secret_get`  
**Prompt:** Get the secret <secret_name> from vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.578479 | `keyvault_secret_get` | ✅ **EXPECTED** |
| 2 | 0.492213 | `keyvault_key_get` | ❌ |
| 3 | 0.488705 | `keyvault_secret_create` | ❌ |
| 4 | 0.443676 | `keyvault_secret_list` | ❌ |
| 5 | 0.424167 | `keyvault_admin_settings_get` | ❌ |

---

## Test 264

**Expected Tool:** `keyvault_secret_get`  
**Prompt:** Display the secret details for <secret_name> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.649267 | `keyvault_secret_get` | ✅ **EXPECTED** |
| 2 | 0.546992 | `keyvault_key_get` | ❌ |
| 3 | 0.497402 | `storage_account_get` | ❌ |
| 4 | 0.494773 | `keyvault_certificate_get` | ❌ |
| 5 | 0.491597 | `keyvault_secret_list` | ❌ |

---

## Test 265

**Expected Tool:** `keyvault_secret_get`  
**Prompt:** Retrieve secret metadata for <secret_name> in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.577477 | `keyvault_secret_get` | ✅ **EXPECTED** |
| 2 | 0.475443 | `keyvault_key_get` | ❌ |
| 3 | 0.466890 | `keyvault_secret_create` | ❌ |
| 4 | 0.447602 | `keyvault_secret_list` | ❌ |
| 5 | 0.439583 | `storage_account_get` | ❌ |

---

## Test 266

**Expected Tool:** `keyvault_secret_list`  
**Prompt:** List all secrets in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.701227 | `keyvault_secret_list` | ✅ **EXPECTED** |
| 2 | 0.563648 | `keyvault_key_list` | ❌ |
| 3 | 0.538430 | `keyvault_certificate_list` | ❌ |
| 4 | 0.499642 | `keyvault_secret_get` | ❌ |
| 5 | 0.455500 | `cosmos_account_list` | ❌ |

---

## Test 267

**Expected Tool:** `keyvault_secret_list`  
**Prompt:** Show me the secrets in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.555681 | `keyvault_secret_list` | ✅ **EXPECTED** |
| 2 | 0.543861 | `keyvault_secret_get` | ❌ |
| 3 | 0.497525 | `keyvault_key_get` | ❌ |
| 4 | 0.464590 | `keyvault_key_list` | ❌ |
| 5 | 0.453130 | `keyvault_admin_settings_get` | ❌ |

---

## Test 268

**Expected Tool:** `keyvault_secret_list`  
**Prompt:** What secrets are in the key vault <key_vault_account_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.572540 | `keyvault_secret_list` | ✅ **EXPECTED** |
| 2 | 0.529258 | `keyvault_secret_get` | ❌ |
| 3 | 0.493648 | `keyvault_key_list` | ❌ |
| 4 | 0.487620 | `keyvault_admin_settings_get` | ❌ |
| 5 | 0.475273 | `keyvault_key_get` | ❌ |

---

## Test 269

**Expected Tool:** `keyvault_secret_list`  
**Prompt:** List secrets names in vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.624290 | `keyvault_secret_list` | ✅ **EXPECTED** |
| 2 | 0.559558 | `keyvault_key_list` | ❌ |
| 3 | 0.517620 | `keyvault_certificate_list` | ❌ |
| 4 | 0.479547 | `keyvault_secret_get` | ❌ |
| 5 | 0.454288 | `storage_blob_container_get` | ❌ |

---

## Test 270

**Expected Tool:** `keyvault_secret_list`  
**Prompt:** Enumerate secrets in key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.742358 | `keyvault_secret_list` | ✅ **EXPECTED** |
| 2 | 0.601089 | `keyvault_key_list` | ❌ |
| 3 | 0.567855 | `keyvault_certificate_list` | ❌ |
| 4 | 0.496127 | `keyvault_secret_get` | ❌ |
| 5 | 0.437560 | `keyvault_admin_settings_get` | ❌ |

---

## Test 271

**Expected Tool:** `keyvault_secret_list`  
**Prompt:** Show secrets names in the key vault <key_vault_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.567149 | `keyvault_secret_list` | ✅ **EXPECTED** |
| 2 | 0.522134 | `keyvault_secret_get` | ❌ |
| 3 | 0.476126 | `keyvault_key_list` | ❌ |
| 4 | 0.462504 | `keyvault_secret_create` | ❌ |
| 5 | 0.461085 | `keyvault_key_get` | ❌ |

---

## Test 272

**Expected Tool:** `aks_cluster_get`  
**Prompt:** Get the configuration of AKS cluster <cluster-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.588300 | `aks_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.544302 | `aks_nodepool_get` | ❌ |
| 3 | 0.517279 | `kusto_cluster_get` | ❌ |
| 4 | 0.481416 | `mysql_server_config_get` | ❌ |
| 5 | 0.430976 | `postgres_server_config_get` | ❌ |

---

## Test 273

**Expected Tool:** `aks_cluster_get`  
**Prompt:** Show me the details of AKS cluster <cluster-name> in resource group <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.621759 | `aks_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.575626 | `aks_nodepool_get` | ❌ |
| 3 | 0.567870 | `kusto_cluster_get` | ❌ |
| 4 | 0.461466 | `sql_db_show` | ❌ |
| 5 | 0.445018 | `monitor_webtests_get` | ❌ |

---

## Test 274

**Expected Tool:** `aks_cluster_get`  
**Prompt:** Show me the network configuration for AKS cluster <cluster-name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.522525 | `aks_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.483220 | `aks_nodepool_get` | ❌ |
| 3 | 0.434684 | `kusto_cluster_get` | ❌ |
| 4 | 0.380301 | `mysql_server_config_get` | ❌ |
| 5 | 0.366689 | `kusto_cluster_list` | ❌ |

---

## Test 275

**Expected Tool:** `aks_cluster_get`  
**Prompt:** What are the details of my AKS cluster <cluster-name> in <resource-group>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.589373 | `aks_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.551576 | `aks_nodepool_get` | ❌ |
| 3 | 0.527983 | `kusto_cluster_get` | ❌ |
| 4 | 0.445186 | `storage_account_get` | ❌ |
| 5 | 0.435137 | `functionapp_get` | ❌ |

---

## Test 276

**Expected Tool:** `aks_cluster_get`  
**Prompt:** List all AKS clusters in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.756471 | `aks_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.749416 | `kusto_cluster_list` | ❌ |
| 3 | 0.590166 | `aks_nodepool_get` | ❌ |
| 4 | 0.568403 | `kusto_database_list` | ❌ |
| 5 | 0.562043 | `search_service_list` | ❌ |

---

## Test 277

**Expected Tool:** `aks_cluster_get`  
**Prompt:** Show me my Azure Kubernetes Service clusters  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.612024 | `aks_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.586492 | `kusto_cluster_list` | ❌ |
| 3 | 0.507661 | `aks_nodepool_get` | ❌ |
| 4 | 0.489601 | `kusto_cluster_get` | ❌ |
| 5 | 0.462787 | `kusto_database_list` | ❌ |

---

## Test 278

**Expected Tool:** `aks_cluster_get`  
**Prompt:** What AKS clusters do I have?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.628429 | `aks_cluster_get` | ✅ **EXPECTED** |
| 2 | 0.563189 | `aks_nodepool_get` | ❌ |
| 3 | 0.526756 | `kusto_cluster_list` | ❌ |
| 4 | 0.426157 | `kusto_cluster_get` | ❌ |
| 5 | 0.409103 | `kusto_database_list` | ❌ |

---

## Test 279

**Expected Tool:** `aks_nodepool_get`  
**Prompt:** Get details for nodepool <nodepool-name> in AKS cluster <cluster-name> in <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.728937 | `aks_nodepool_get` | ✅ **EXPECTED** |
| 2 | 0.517021 | `kusto_cluster_get` | ❌ |
| 3 | 0.509820 | `aks_cluster_get` | ❌ |
| 4 | 0.468472 | `virtualdesktop_hostpool_list` | ❌ |
| 5 | 0.463192 | `sql_elastic-pool_list` | ❌ |

---

## Test 280

**Expected Tool:** `aks_nodepool_get`  
**Prompt:** Show me the configuration for nodepool <nodepool-name> in AKS cluster <cluster-name> in resource group <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.654130 | `aks_nodepool_get` | ✅ **EXPECTED** |
| 2 | 0.458636 | `sql_elastic-pool_list` | ❌ |
| 3 | 0.446000 | `aks_cluster_get` | ❌ |
| 4 | 0.440302 | `virtualdesktop_hostpool_list` | ❌ |
| 5 | 0.413727 | `kusto_cluster_get` | ❌ |

---

## Test 281

**Expected Tool:** `aks_nodepool_get`  
**Prompt:** What is the setup of nodepool <nodepool-name> for AKS cluster <cluster-name> in <resource-group>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.592806 | `aks_nodepool_get` | ✅ **EXPECTED** |
| 2 | 0.402556 | `aks_cluster_get` | ❌ |
| 3 | 0.385236 | `virtualdesktop_hostpool_list` | ❌ |
| 4 | 0.383045 | `sql_elastic-pool_list` | ❌ |
| 5 | 0.355090 | `kusto_cluster_get` | ❌ |

---

## Test 282

**Expected Tool:** `aks_nodepool_get`  
**Prompt:** List nodepools for AKS cluster <cluster-name> in <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.692231 | `aks_nodepool_get` | ✅ **EXPECTED** |
| 2 | 0.519037 | `aks_cluster_get` | ❌ |
| 3 | 0.506704 | `virtualdesktop_hostpool_list` | ❌ |
| 4 | 0.500749 | `kusto_cluster_list` | ❌ |
| 5 | 0.487707 | `sql_elastic-pool_list` | ❌ |

---

## Test 283

**Expected Tool:** `aks_nodepool_get`  
**Prompt:** Show me the nodepool list for AKS cluster <cluster-name> in <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.732132 | `aks_nodepool_get` | ✅ **EXPECTED** |
| 2 | 0.561829 | `aks_cluster_get` | ❌ |
| 3 | 0.510269 | `sql_elastic-pool_list` | ❌ |
| 4 | 0.509840 | `virtualdesktop_hostpool_list` | ❌ |
| 5 | 0.486700 | `kusto_cluster_list` | ❌ |

---

## Test 284

**Expected Tool:** `aks_nodepool_get`  
**Prompt:** What nodepools do I have for AKS cluster <cluster-name> in <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.629358 | `aks_nodepool_get` | ✅ **EXPECTED** |
| 2 | 0.456911 | `aks_cluster_get` | ❌ |
| 3 | 0.443942 | `virtualdesktop_hostpool_list` | ❌ |
| 4 | 0.433006 | `kusto_cluster_list` | ❌ |
| 5 | 0.425448 | `sql_elastic-pool_list` | ❌ |

---

## Test 285

**Expected Tool:** `loadtesting_test_create`  
**Prompt:** Create a basic URL test using the following endpoint URL <test-url> that runs for 30 minutes with 45 virtual users. The test name is <sample-name> with the test id <test-id> and the load testing resource is <load-test-resource> in the resource group <resource-group> in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.577811 | `loadtesting_test_create` | ✅ **EXPECTED** |
| 2 | 0.519418 | `loadtesting_testresource_create` | ❌ |
| 3 | 0.512099 | `loadtesting_testrun_create` | ❌ |
| 4 | 0.472753 | `monitor_webtests_create` | ❌ |
| 5 | 0.460615 | `loadtesting_testresource_list` | ❌ |

---

## Test 286

**Expected Tool:** `loadtesting_test_get`  
**Prompt:** Get the load test with id <test-id> in the load test resource <test-resource> in resource group <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.626167 | `loadtesting_testresource_list` | ❌ |
| 2 | 0.619944 | `loadtesting_test_get` | ✅ **EXPECTED** |
| 3 | 0.594666 | `loadtesting_testresource_create` | ❌ |
| 4 | 0.591091 | `monitor_webtests_get` | ❌ |
| 5 | 0.538016 | `monitor_webtests_list` | ❌ |

---

## Test 287

**Expected Tool:** `loadtesting_testresource_create`  
**Prompt:** Create a load test resource <load-test-resource-name> in the resource group <resource-group> in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.645537 | `loadtesting_testresource_create` | ✅ **EXPECTED** |
| 2 | 0.618695 | `loadtesting_testresource_list` | ❌ |
| 3 | 0.541746 | `loadtesting_test_create` | ❌ |
| 4 | 0.539771 | `loadtesting_testrun_create` | ❌ |
| 5 | 0.526845 | `monitor_webtests_list` | ❌ |

---

## Test 288

**Expected Tool:** `loadtesting_testresource_list`  
**Prompt:** List all load testing resources in the resource group <resource-group> in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.794221 | `loadtesting_testresource_list` | ✅ **EXPECTED** |
| 2 | 0.652433 | `monitor_webtests_list` | ❌ |
| 3 | 0.577408 | `group_list` | ❌ |
| 4 | 0.575172 | `loadtesting_testresource_create` | ❌ |
| 5 | 0.565565 | `datadog_monitoredresources_list` | ❌ |

---

## Test 289

**Expected Tool:** `loadtesting_testrun_create`  
**Prompt:** Create a test run using the id <testrun-id> for test <test-id> in the load testing resource <load-testing-resource> in resource group <resource-group>. Use the name of test run <display-name> and description as <description>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.688976 | `loadtesting_testrun_create` | ✅ **EXPECTED** |
| 2 | 0.594879 | `loadtesting_testrun_update` | ❌ |
| 3 | 0.558636 | `loadtesting_test_create` | ❌ |
| 4 | 0.547102 | `loadtesting_testresource_create` | ❌ |
| 5 | 0.496168 | `loadtesting_testresource_list` | ❌ |

---

## Test 290

**Expected Tool:** `loadtesting_testrun_get`  
**Prompt:** Get the load test run with id <testrun-id> in the load test resource <test-resource> in resource group <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.619084 | `loadtesting_testresource_list` | ❌ |
| 2 | 0.601927 | `loadtesting_test_get` | ❌ |
| 3 | 0.597430 | `loadtesting_testresource_create` | ❌ |
| 4 | 0.577861 | `monitor_webtests_get` | ❌ |
| 5 | 0.565996 | `loadtesting_testrun_list` | ❌ |

---

## Test 291

**Expected Tool:** `loadtesting_testrun_list`  
**Prompt:** Get all the load test runs for the test with id <test-id> in the load test resource <test-resource> in resource group <resource-group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.669096 | `loadtesting_testresource_list` | ❌ |
| 2 | 0.640360 | `loadtesting_testrun_list` | ✅ **EXPECTED** |
| 3 | 0.601075 | `loadtesting_test_get` | ❌ |
| 4 | 0.577461 | `loadtesting_testresource_create` | ❌ |
| 5 | 0.569933 | `monitor_webtests_get` | ❌ |

---

## Test 292

**Expected Tool:** `loadtesting_testrun_update`  
**Prompt:** Update a test run display name as <display-name> for the id <testrun-id> for test <test-id> in the load testing resource <load-testing-resource> in resource group <resource-group>.  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.706747 | `loadtesting_testrun_update` | ✅ **EXPECTED** |
| 2 | 0.514428 | `loadtesting_testrun_create` | ❌ |
| 3 | 0.487069 | `monitor_webtests_update` | ❌ |
| 4 | 0.470322 | `loadtesting_testresource_list` | ❌ |
| 5 | 0.468095 | `monitor_webtests_get` | ❌ |

---

## Test 293

**Expected Tool:** `grafana_list`  
**Prompt:** List all Azure Managed Grafana in one subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.599427 | `kusto_cluster_list` | ❌ |
| 2 | 0.578892 | `grafana_list` | ✅ **EXPECTED** |
| 3 | 0.551851 | `search_service_list` | ❌ |
| 4 | 0.550372 | `subscription_list` | ❌ |
| 5 | 0.531259 | `redis_list` | ❌ |

---

## Test 294

**Expected Tool:** `managedlustre_fs_create`  
**Prompt:** Create an Azure Managed Lustre filesystem with name <filesystem_name>, size <filesystem_size>, SKU <sku>, and subnet <subnet_id> for availability zone <zone> in location <location>. Maintenance should occur on <maintenance_window_day> at <maintenance_window_time>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.725915 | `managedlustre_fs_create` | ✅ **EXPECTED** |
| 2 | 0.616144 | `managedlustre_fs_list` | ❌ |
| 3 | 0.605775 | `managedlustre_fs_sku_get` | ❌ |
| 4 | 0.598255 | `managedlustre_fs_update` | ❌ |
| 5 | 0.557720 | `managedlustre_fs_subnetsize_validate` | ❌ |

---

## Test 295

**Expected Tool:** `managedlustre_fs_list`  
**Prompt:** List the Azure Managed Lustre filesystems in my subscription <subscription_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.750589 | `managedlustre_fs_list` | ✅ **EXPECTED** |
| 2 | 0.631770 | `managedlustre_fs_sku_get` | ❌ |
| 3 | 0.579641 | `managedlustre_fs_create` | ❌ |
| 4 | 0.562377 | `kusto_cluster_list` | ❌ |
| 5 | 0.513156 | `search_service_list` | ❌ |

---

## Test 296

**Expected Tool:** `managedlustre_fs_list`  
**Prompt:** List the Azure Managed Lustre filesystems in my resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.743775 | `managedlustre_fs_list` | ✅ **EXPECTED** |
| 2 | 0.613217 | `managedlustre_fs_sku_get` | ❌ |
| 3 | 0.562723 | `managedlustre_fs_create` | ❌ |
| 4 | 0.519986 | `datadog_monitoredresources_list` | ❌ |
| 5 | 0.515413 | `loadtesting_testresource_list` | ❌ |

---

## Test 297

**Expected Tool:** `managedlustre_fs_sku_get`  
**Prompt:** List the Azure Managed Lustre SKUs available in location <location>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.827381 | `managedlustre_fs_sku_get` | ✅ **EXPECTED** |
| 2 | 0.613609 | `managedlustre_fs_list` | ❌ |
| 3 | 0.511274 | `managedlustre_fs_create` | ❌ |
| 4 | 0.496242 | `managedlustre_fs_subnetsize_validate` | ❌ |
| 5 | 0.470241 | `kusto_cluster_list` | ❌ |

---

## Test 298

**Expected Tool:** `managedlustre_fs_subnetsize_ask`  
**Prompt:** Tell me how many IP addresses I need for an Azure Managed Lustre filesystem of size <filesystem_size> using the SKU <sku>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.739913 | `managedlustre_fs_subnetsize_ask` | ✅ **EXPECTED** |
| 2 | 0.651598 | `managedlustre_fs_subnetsize_validate` | ❌ |
| 3 | 0.594585 | `managedlustre_fs_sku_get` | ❌ |
| 4 | 0.559524 | `managedlustre_fs_list` | ❌ |
| 5 | 0.533442 | `managedlustre_fs_create` | ❌ |

---

## Test 299

**Expected Tool:** `managedlustre_fs_subnetsize_validate`  
**Prompt:** Validate if the network <subnet_id> can host Azure Managed Lustre filesystem of size <filesystem_size> using the SKU <sku>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.879389 | `managedlustre_fs_subnetsize_validate` | ✅ **EXPECTED** |
| 2 | 0.622844 | `managedlustre_fs_subnetsize_ask` | ❌ |
| 3 | 0.542808 | `managedlustre_fs_sku_get` | ❌ |
| 4 | 0.515748 | `managedlustre_fs_create` | ❌ |
| 5 | 0.480811 | `managedlustre_fs_list` | ❌ |

---

## Test 300

**Expected Tool:** `managedlustre_fs_update`  
**Prompt:** Update the maintenance window of the Azure Managed Lustre filesystem <filesystem_name> to <maintenance_window_day> at <maintenance_window_time>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.739000 | `managedlustre_fs_update` | ✅ **EXPECTED** |
| 2 | 0.525067 | `managedlustre_fs_create` | ❌ |
| 3 | 0.487221 | `managedlustre_fs_list` | ❌ |
| 4 | 0.385349 | `managedlustre_fs_sku_get` | ❌ |
| 5 | 0.344891 | `managedlustre_fs_subnetsize_validate` | ❌ |

---

## Test 301

**Expected Tool:** `marketplace_product_get`  
**Prompt:** Get details about marketplace product <product_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.571325 | `marketplace_product_get` | ✅ **EXPECTED** |
| 2 | 0.496964 | `marketplace_product_list` | ❌ |
| 3 | 0.356275 | `servicebus_topic_subscription_details` | ❌ |
| 4 | 0.336045 | `servicebus_topic_details` | ❌ |
| 5 | 0.334329 | `servicebus_queue_details` | ❌ |

---

## Test 302

**Expected Tool:** `marketplace_product_list`  
**Prompt:** Search for Microsoft products in the marketplace  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.607917 | `marketplace_product_list` | ✅ **EXPECTED** |
| 2 | 0.443133 | `marketplace_product_get` | ❌ |
| 3 | 0.343549 | `search_service_list` | ❌ |
| 4 | 0.330503 | `foundry_models_list` | ❌ |
| 5 | 0.328676 | `managedlustre_fs_sku_get` | ❌ |

---

## Test 303

**Expected Tool:** `marketplace_product_list`  
**Prompt:** Show me marketplace products from publisher <publisher_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.537726 | `marketplace_product_list` | ✅ **EXPECTED** |
| 2 | 0.385167 | `marketplace_product_get` | ❌ |
| 3 | 0.308789 | `foundry_models_list` | ❌ |
| 4 | 0.288006 | `redis_list` | ❌ |
| 5 | 0.260387 | `managedlustre_fs_sku_get` | ❌ |

---

## Test 304

**Expected Tool:** `azureagentbestpractices_get`  
**Prompt:** Get best practices for building AI applications in Azure  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.732941 | `azureagentbestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.555579 | `get_bestpractices_get` | ❌ |
| 3 | 0.501210 | `azureterraformbestpractices_get` | ❌ |
| 4 | 0.480235 | `deploy_pipeline_guidance_get` | ❌ |
| 5 | 0.478262 | `cloudarchitect_design` | ❌ |

---

## Test 305

**Expected Tool:** `azureagentbestpractices_get`  
**Prompt:** Show me best practices for Azure AI Foundry agents  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.694322 | `azureagentbestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.575866 | `foundry_agents_list` | ❌ |
| 3 | 0.511895 | `foundry_agents_connect` | ❌ |
| 4 | 0.486966 | `get_bestpractices_get` | ❌ |
| 5 | 0.461123 | `foundry_resource_get` | ❌ |

---

## Test 306

**Expected Tool:** `azureagentbestpractices_get`  
**Prompt:** Get guidance for building agents with Azure AI Foundry  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.656208 | `azureagentbestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.553662 | `foundry_agents_list` | ❌ |
| 3 | 0.513217 | `foundry_agents_connect` | ❌ |
| 4 | 0.505706 | `deploy_pipeline_guidance_get` | ❌ |
| 5 | 0.488904 | `foundry_resource_get` | ❌ |

---

## Test 307

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** Get the latest Azure code generation best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.646805 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.635334 | `azureterraformbestpractices_get` | ❌ |
| 3 | 0.627140 | `azureagentbestpractices_get` | ❌ |
| 4 | 0.586920 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.531723 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 308

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** Get the latest Azure deployment best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.600903 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.560655 | `azureagentbestpractices_get` | ❌ |
| 3 | 0.548542 | `azureterraformbestpractices_get` | ❌ |
| 4 | 0.541088 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.516852 | `deploy_plan_get` | ❌ |

---

## Test 309

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** Get the latest Azure best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.625259 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.608463 | `azureagentbestpractices_get` | ❌ |
| 3 | 0.594323 | `azureterraformbestpractices_get` | ❌ |
| 4 | 0.518699 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.465573 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 310

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** Get the latest Azure Functions code generation best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.624273 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.570488 | `azureterraformbestpractices_get` | ❌ |
| 3 | 0.559895 | `azureagentbestpractices_get` | ❌ |
| 4 | 0.523035 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.493998 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 311

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** Get the latest Azure Functions deployment best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.581850 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.513643 | `azureagentbestpractices_get` | ❌ |
| 3 | 0.497350 | `deploy_pipeline_guidance_get` | ❌ |
| 4 | 0.495652 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.486886 | `azureterraformbestpractices_get` | ❌ |

---

## Test 312

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** Get the latest Azure Functions best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.610986 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.564414 | `azureagentbestpractices_get` | ❌ |
| 3 | 0.532790 | `azureterraformbestpractices_get` | ❌ |
| 4 | 0.487361 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.458060 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 313

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** Get the latest Azure Static Web Apps best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.557862 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.545028 | `azureagentbestpractices_get` | ❌ |
| 3 | 0.513262 | `azureterraformbestpractices_get` | ❌ |
| 4 | 0.505148 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.483705 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 314

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** What are azure function best practices?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.582475 | `get_bestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.516975 | `azureagentbestpractices_get` | ❌ |
| 3 | 0.500295 | `azureterraformbestpractices_get` | ❌ |
| 4 | 0.472036 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.433088 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 315

**Expected Tool:** `get_bestpractices_get`  
**Prompt:** configure azure mcp in coding agent for my repo  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.488855 | `deploy_plan_get` | ❌ |
| 2 | 0.460956 | `deploy_pipeline_guidance_get` | ❌ |
| 3 | 0.390294 | `deploy_iac_rules_get` | ❌ |
| 4 | 0.376157 | `azureagentbestpractices_get` | ❌ |
| 5 | 0.370298 | `azureterraformbestpractices_get` | ❌ |

---

## Test 316

**Expected Tool:** `monitor_activitylog_list`  
**Prompt:** List the activity logs of the last month for <resource_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.537893 | `monitor_activitylog_list` | ✅ **EXPECTED** |
| 2 | 0.506212 | `monitor_resource_log_query` | ❌ |
| 3 | 0.371728 | `monitor_workspace_log_query` | ❌ |
| 4 | 0.363798 | `resourcehealth_health-events_list` | ❌ |
| 5 | 0.344629 | `datadog_monitoredresources_list` | ❌ |

---

## Test 317

**Expected Tool:** `monitor_healthmodels_entity_get`  
**Prompt:** Show me the health status of entity <entity_id> using the health model <health_model_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.660947 | `monitor_healthmodels_entity_get` | ✅ **EXPECTED** |
| 2 | 0.609276 | `resourcehealth_availability-status_get` | ❌ |
| 3 | 0.351796 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.328321 | `resourcehealth_health-events_list` | ❌ |
| 5 | 0.288705 | `foundry_models_deployments_list` | ❌ |

---

## Test 318

**Expected Tool:** `monitor_metrics_definitions`  
**Prompt:** Get metric definitions for <resource_type> <resource_name> from the namespace  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.592640 | `monitor_metrics_definitions` | ✅ **EXPECTED** |
| 2 | 0.423956 | `monitor_metrics_query` | ❌ |
| 3 | 0.368319 | `bicepschema_get` | ❌ |
| 4 | 0.332369 | `monitor_table_type_list` | ❌ |
| 5 | 0.324986 | `resourcehealth_availability-status_get` | ❌ |

---

## Test 319

**Expected Tool:** `monitor_metrics_definitions`  
**Prompt:** Show me all available metrics and their definitions for storage account <account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.607600 | `storage_account_get` | ❌ |
| 2 | 0.587736 | `monitor_metrics_definitions` | ✅ **EXPECTED** |
| 3 | 0.544781 | `storage_blob_container_get` | ❌ |
| 4 | 0.495829 | `storage_blob_get` | ❌ |
| 5 | 0.473468 | `managedlustre_fs_list` | ❌ |

---

## Test 320

**Expected Tool:** `monitor_metrics_definitions`  
**Prompt:** What metric definitions are available for the Application Insights resource <resource_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.633173 | `monitor_metrics_definitions` | ✅ **EXPECTED** |
| 2 | 0.495386 | `monitor_metrics_query` | ❌ |
| 3 | 0.433945 | `monitor_resource_log_query` | ❌ |
| 4 | 0.392843 | `loadtesting_testresource_list` | ❌ |
| 5 | 0.388750 | `bicepschema_get` | ❌ |

---

## Test 321

**Expected Tool:** `monitor_metrics_query`  
**Prompt:** Analyze the performance trends and response times for Application Insights resource <resource_name> over the last <time_period>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.555553 | `monitor_metrics_query` | ✅ **EXPECTED** |
| 2 | 0.527220 | `monitor_resource_log_query` | ❌ |
| 3 | 0.464972 | `applens_resource_diagnose` | ❌ |
| 4 | 0.420116 | `resourcehealth_health-events_list` | ❌ |
| 5 | 0.412799 | `applicationinsights_recommendation_list` | ❌ |

---

## Test 322

**Expected Tool:** `monitor_metrics_query`  
**Prompt:** Check the availability metrics for my Application Insights resource <resource_name> for the last <time_period>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.557842 | `monitor_metrics_query` | ✅ **EXPECTED** |
| 2 | 0.476671 | `monitor_resource_log_query` | ❌ |
| 3 | 0.460584 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.455904 | `quota_usage_check` | ❌ |
| 5 | 0.438233 | `monitor_metrics_definitions` | ❌ |

---

## Test 323

**Expected Tool:** `monitor_metrics_query`  
**Prompt:** Get the <aggregation_type> <metric_name> metric for <resource_type> <resource_name> over the last <time_period> with intervals  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.461261 | `monitor_metrics_query` | ✅ **EXPECTED** |
| 2 | 0.390029 | `monitor_metrics_definitions` | ❌ |
| 3 | 0.338557 | `monitor_resource_log_query` | ❌ |
| 4 | 0.334519 | `resourcehealth_availability-status_get` | ❌ |
| 5 | 0.306388 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 324

**Expected Tool:** `monitor_metrics_query`  
**Prompt:** Investigate error rates and failed requests for Application Insights resource <resource_name> for the last <time_period>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.496878 | `monitor_resource_log_query` | ❌ |
| 2 | 0.491789 | `monitor_metrics_query` | ✅ **EXPECTED** |
| 3 | 0.448148 | `applens_resource_diagnose` | ❌ |
| 4 | 0.412184 | `resourcehealth_health-events_list` | ❌ |
| 5 | 0.397335 | `quota_usage_check` | ❌ |

---

## Test 325

**Expected Tool:** `monitor_metrics_query`  
**Prompt:** Query the <metric_name> metric for <resource_type> <resource_name> for the last <time_period>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.525295 | `monitor_metrics_query` | ✅ **EXPECTED** |
| 2 | 0.406185 | `monitor_resource_log_query` | ❌ |
| 3 | 0.384482 | `monitor_metrics_definitions` | ❌ |
| 4 | 0.347723 | `monitor_workspace_log_query` | ❌ |
| 5 | 0.330713 | `resourcehealth_availability-status_get` | ❌ |

---

## Test 326

**Expected Tool:** `monitor_metrics_query`  
**Prompt:** What's the request per second rate for my Application Insights resource <resource_name> over the last <time_period>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.480375 | `monitor_metrics_query` | ✅ **EXPECTED** |
| 2 | 0.444779 | `monitor_resource_log_query` | ❌ |
| 3 | 0.388382 | `applens_resource_diagnose` | ❌ |
| 4 | 0.363411 | `quota_usage_check` | ❌ |
| 5 | 0.350076 | `resourcehealth_health-events_list` | ❌ |

---

## Test 327

**Expected Tool:** `monitor_resource_log_query`  
**Prompt:** Show me the logs for the past hour for the resource <resource_name> in the Log Analytics workspace <workspace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.687656 | `monitor_resource_log_query` | ✅ **EXPECTED** |
| 2 | 0.621682 | `monitor_workspace_log_query` | ❌ |
| 3 | 0.598427 | `monitor_activitylog_list` | ❌ |
| 4 | 0.485643 | `deploy_app_logs_get` | ❌ |
| 5 | 0.470208 | `monitor_metrics_query` | ❌ |

---

## Test 328

**Expected Tool:** `monitor_table_list`  
**Prompt:** List all tables in the Log Analytics workspace <workspace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.851246 | `monitor_table_list` | ✅ **EXPECTED** |
| 2 | 0.725693 | `monitor_table_type_list` | ❌ |
| 3 | 0.620445 | `monitor_workspace_list` | ❌ |
| 4 | 0.541928 | `kusto_table_list` | ❌ |
| 5 | 0.539481 | `monitor_workspace_log_query` | ❌ |

---

## Test 329

**Expected Tool:** `monitor_table_list`  
**Prompt:** Show me the tables in the Log Analytics workspace <workspace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.798879 | `monitor_table_list` | ✅ **EXPECTED** |
| 2 | 0.701092 | `monitor_table_type_list` | ❌ |
| 3 | 0.599916 | `monitor_workspace_list` | ❌ |
| 4 | 0.542820 | `monitor_workspace_log_query` | ❌ |
| 5 | 0.502882 | `monitor_resource_log_query` | ❌ |

---

## Test 330

**Expected Tool:** `monitor_table_type_list`  
**Prompt:** List all available table types in the Log Analytics workspace <workspace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.881468 | `monitor_table_type_list` | ✅ **EXPECTED** |
| 2 | 0.765714 | `monitor_table_list` | ❌ |
| 3 | 0.569921 | `monitor_workspace_list` | ❌ |
| 4 | 0.504683 | `mysql_table_list` | ❌ |
| 5 | 0.497622 | `monitor_workspace_log_query` | ❌ |

---

## Test 331

**Expected Tool:** `monitor_table_type_list`  
**Prompt:** Show me the available table types in the Log Analytics workspace <workspace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.843110 | `monitor_table_type_list` | ✅ **EXPECTED** |
| 2 | 0.736977 | `monitor_table_list` | ❌ |
| 3 | 0.576731 | `monitor_workspace_list` | ❌ |
| 4 | 0.509598 | `monitor_workspace_log_query` | ❌ |
| 5 | 0.481189 | `mysql_table_list` | ❌ |

---

## Test 332

**Expected Tool:** `monitor_webtests_create`  
**Prompt:** Create a new Standard Web Test with name <webtest_resource_name> in my subscription in <resource_group> in a given <appinsights_component>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.650734 | `monitor_webtests_create` | ✅ **EXPECTED** |
| 2 | 0.572501 | `monitor_webtests_list` | ❌ |
| 3 | 0.550098 | `monitor_webtests_update` | ❌ |
| 4 | 0.533459 | `monitor_webtests_get` | ❌ |
| 5 | 0.482145 | `loadtesting_testresource_create` | ❌ |

---

## Test 333

**Expected Tool:** `monitor_webtests_get`  
**Prompt:** Get Web Test details for <webtest_resource_name> in my subscription in <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.759367 | `monitor_webtests_get` | ✅ **EXPECTED** |
| 2 | 0.726248 | `monitor_webtests_list` | ❌ |
| 3 | 0.583743 | `loadtesting_testresource_list` | ❌ |
| 4 | 0.563026 | `monitor_webtests_update` | ❌ |
| 5 | 0.530624 | `monitor_webtests_create` | ❌ |

---

## Test 334

**Expected Tool:** `monitor_webtests_list`  
**Prompt:** List all Web Test resources in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.732322 | `monitor_webtests_list` | ✅ **EXPECTED** |
| 2 | 0.610019 | `loadtesting_testresource_list` | ❌ |
| 3 | 0.547699 | `grafana_list` | ❌ |
| 4 | 0.520834 | `redis_list` | ❌ |
| 5 | 0.496536 | `monitor_webtests_get` | ❌ |

---

## Test 335

**Expected Tool:** `monitor_webtests_list`  
**Prompt:** List all Web Test resources in my subscription in <resource_group>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.793764 | `monitor_webtests_list` | ✅ **EXPECTED** |
| 2 | 0.675851 | `loadtesting_testresource_list` | ❌ |
| 3 | 0.585010 | `monitor_webtests_get` | ❌ |
| 4 | 0.573602 | `group_list` | ❌ |
| 5 | 0.546163 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 336

**Expected Tool:** `monitor_webtests_update`  
**Prompt:** Update an existing Standard Web Test with name <webtest_resource_name> in my subscription in <resource_group> in a given <appinsights_component>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.686349 | `monitor_webtests_update` | ✅ **EXPECTED** |
| 2 | 0.559399 | `monitor_webtests_get` | ❌ |
| 3 | 0.558099 | `monitor_webtests_create` | ❌ |
| 4 | 0.556349 | `monitor_webtests_list` | ❌ |
| 5 | 0.508977 | `loadtesting_testrun_update` | ❌ |

---

## Test 337

**Expected Tool:** `monitor_workspace_list`  
**Prompt:** List all Log Analytics workspaces in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.813902 | `monitor_workspace_list` | ✅ **EXPECTED** |
| 2 | 0.680201 | `grafana_list` | ❌ |
| 3 | 0.660028 | `monitor_table_list` | ❌ |
| 4 | 0.610623 | `kusto_cluster_list` | ❌ |
| 5 | 0.600802 | `search_service_list` | ❌ |

---

## Test 338

**Expected Tool:** `monitor_workspace_list`  
**Prompt:** Show me my Log Analytics workspaces  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.656194 | `monitor_workspace_list` | ✅ **EXPECTED** |
| 2 | 0.585561 | `monitor_table_list` | ❌ |
| 3 | 0.531094 | `monitor_table_type_list` | ❌ |
| 4 | 0.518254 | `grafana_list` | ❌ |
| 5 | 0.506772 | `monitor_workspace_log_query` | ❌ |

---

## Test 339

**Expected Tool:** `monitor_workspace_list`  
**Prompt:** Show me the Log Analytics workspaces in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.732908 | `monitor_workspace_list` | ✅ **EXPECTED** |
| 2 | 0.601457 | `grafana_list` | ❌ |
| 3 | 0.580404 | `monitor_table_list` | ❌ |
| 4 | 0.523646 | `monitor_workspace_log_query` | ❌ |
| 5 | 0.522671 | `kusto_cluster_list` | ❌ |

---

## Test 340

**Expected Tool:** `monitor_workspace_log_query`  
**Prompt:** Show me the logs for the past hour in the Log Analytics workspace <workspace_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.610115 | `monitor_workspace_log_query` | ✅ **EXPECTED** |
| 2 | 0.587614 | `monitor_resource_log_query` | ❌ |
| 3 | 0.527733 | `monitor_activitylog_list` | ❌ |
| 4 | 0.498446 | `deploy_app_logs_get` | ❌ |
| 5 | 0.486290 | `monitor_table_list` | ❌ |

---

## Test 341

**Expected Tool:** `datadog_monitoredresources_list`  
**Prompt:** List all monitored resources in the Datadog resource <resource_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.668828 | `datadog_monitoredresources_list` | ✅ **EXPECTED** |
| 2 | 0.454270 | `redis_list` | ❌ |
| 3 | 0.413561 | `loadtesting_testresource_list` | ❌ |
| 4 | 0.413250 | `monitor_metrics_query` | ❌ |
| 5 | 0.401731 | `grafana_list` | ❌ |

---

## Test 342

**Expected Tool:** `datadog_monitoredresources_list`  
**Prompt:** Show me the monitored resources in the Datadog resource <resource_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.624066 | `datadog_monitoredresources_list` | ✅ **EXPECTED** |
| 2 | 0.443858 | `monitor_metrics_query` | ❌ |
| 3 | 0.440052 | `redis_list` | ❌ |
| 4 | 0.424391 | `monitor_resource_log_query` | ❌ |
| 5 | 0.385044 | `loadtesting_testresource_list` | ❌ |

---

## Test 343

**Expected Tool:** `extension_azqr`  
**Prompt:** Check my Azure subscription for any compliance issues or recommendations  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.533147 | `quota_usage_check` | ❌ |
| 2 | 0.481112 | `azureterraformbestpractices_get` | ❌ |
| 3 | 0.476765 | `extension_azqr` | ✅ **EXPECTED** |
| 4 | 0.471527 | `subscription_list` | ❌ |
| 5 | 0.468417 | `applens_resource_diagnose` | ❌ |

---

## Test 344

**Expected Tool:** `extension_azqr`  
**Prompt:** Provide compliance recommendations for my current Azure subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.532780 | `azureterraformbestpractices_get` | ❌ |
| 2 | 0.492873 | `get_bestpractices_get` | ❌ |
| 3 | 0.476184 | `applicationinsights_recommendation_list` | ❌ |
| 4 | 0.473393 | `deploy_iac_rules_get` | ❌ |
| 5 | 0.473393 | `azureagentbestpractices_get` | ❌ |

---

## Test 345

**Expected Tool:** `extension_azqr`  
**Prompt:** Scan my Azure subscription for compliance recommendations  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.536934 | `azureterraformbestpractices_get` | ❌ |
| 2 | 0.516925 | `extension_azqr` | ✅ **EXPECTED** |
| 3 | 0.514978 | `applicationinsights_recommendation_list` | ❌ |
| 4 | 0.504673 | `quota_usage_check` | ❌ |
| 5 | 0.494872 | `deploy_plan_get` | ❌ |

---

## Test 346

**Expected Tool:** `quota_region_availability_list`  
**Prompt:** Show me the available regions for these resource types <resource_types>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.590433 | `quota_region_availability_list` | ✅ **EXPECTED** |
| 2 | 0.414024 | `quota_usage_check` | ❌ |
| 3 | 0.390959 | `redis_list` | ❌ |
| 4 | 0.373466 | `resourcehealth_availability-status_list` | ❌ |
| 5 | 0.369869 | `managedlustre_fs_sku_get` | ❌ |

---

## Test 347

**Expected Tool:** `quota_usage_check`  
**Prompt:** Check usage information for <resource_type> in region <region>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.609244 | `quota_usage_check` | ✅ **EXPECTED** |
| 2 | 0.491101 | `quota_region_availability_list` | ❌ |
| 3 | 0.384374 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.376368 | `resourcehealth_availability-status_get` | ❌ |
| 5 | 0.371407 | `redis_list` | ❌ |

---

## Test 348

**Expected Tool:** `role_assignment_list`  
**Prompt:** List all available role assignments in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.645191 | `role_assignment_list` | ✅ **EXPECTED** |
| 2 | 0.539737 | `subscription_list` | ❌ |
| 3 | 0.484004 | `group_list` | ❌ |
| 4 | 0.478738 | `grafana_list` | ❌ |
| 5 | 0.471424 | `cosmos_account_list` | ❌ |

---

## Test 349

**Expected Tool:** `role_assignment_list`  
**Prompt:** Show me the available role assignments in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.609634 | `role_assignment_list` | ✅ **EXPECTED** |
| 2 | 0.514696 | `subscription_list` | ❌ |
| 3 | 0.456956 | `grafana_list` | ❌ |
| 4 | 0.449174 | `eventgrid_subscription_list` | ❌ |
| 5 | 0.445149 | `redis_list` | ❌ |

---

## Test 350

**Expected Tool:** `redis_list`  
**Prompt:** List all Redis resources in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.810504 | `redis_list` | ✅ **EXPECTED** |
| 2 | 0.587836 | `grafana_list` | ❌ |
| 3 | 0.512954 | `kusto_cluster_list` | ❌ |
| 4 | 0.508532 | `datadog_monitoredresources_list` | ❌ |
| 5 | 0.501218 | `postgres_server_list` | ❌ |

---

## Test 351

**Expected Tool:** `redis_list`  
**Prompt:** Show me my Redis resources  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.685128 | `redis_list` | ✅ **EXPECTED** |
| 2 | 0.374327 | `grafana_list` | ❌ |
| 3 | 0.364197 | `datadog_monitoredresources_list` | ❌ |
| 4 | 0.359659 | `mysql_server_list` | ❌ |
| 5 | 0.331502 | `mysql_database_list` | ❌ |

---

## Test 352

**Expected Tool:** `redis_list`  
**Prompt:** Show me the Redis resources in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.781228 | `redis_list` | ✅ **EXPECTED** |
| 2 | 0.539177 | `grafana_list` | ❌ |
| 3 | 0.449276 | `datadog_monitoredresources_list` | ❌ |
| 4 | 0.449014 | `postgres_server_list` | ❌ |
| 5 | 0.442854 | `kusto_cluster_list` | ❌ |

---

## Test 353

**Expected Tool:** `redis_list`  
**Prompt:** Show me my Redis caches  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.572767 | `redis_list` | ✅ **EXPECTED** |
| 2 | 0.316630 | `mysql_database_list` | ❌ |
| 3 | 0.301685 | `postgres_database_list` | ❌ |
| 4 | 0.286513 | `mysql_server_list` | ❌ |
| 5 | 0.273014 | `kusto_cluster_list` | ❌ |

---

## Test 354

**Expected Tool:** `redis_list`  
**Prompt:** Get Redis clusters  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.478070 | `redis_list` | ✅ **EXPECTED** |
| 2 | 0.456308 | `kusto_cluster_list` | ❌ |
| 3 | 0.384630 | `kusto_cluster_get` | ❌ |
| 4 | 0.359434 | `kusto_database_list` | ❌ |
| 5 | 0.343305 | `aks_cluster_get` | ❌ |

---

## Test 355

**Expected Tool:** `group_list`  
**Prompt:** List all resource groups in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.755935 | `group_list` | ✅ **EXPECTED** |
| 2 | 0.566552 | `workbooks_list` | ❌ |
| 3 | 0.564488 | `loadtesting_testresource_list` | ❌ |
| 4 | 0.552633 | `datadog_monitoredresources_list` | ❌ |
| 5 | 0.546225 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 356

**Expected Tool:** `group_list`  
**Prompt:** Show me my resource groups  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.529504 | `group_list` | ✅ **EXPECTED** |
| 2 | 0.464690 | `redis_list` | ❌ |
| 3 | 0.463685 | `datadog_monitoredresources_list` | ❌ |
| 4 | 0.462391 | `mysql_server_list` | ❌ |
| 5 | 0.460238 | `loadtesting_testresource_list` | ❌ |

---

## Test 357

**Expected Tool:** `group_list`  
**Prompt:** Show me the resource groups in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.665772 | `group_list` | ✅ **EXPECTED** |
| 2 | 0.532656 | `datadog_monitoredresources_list` | ❌ |
| 3 | 0.532505 | `redis_list` | ❌ |
| 4 | 0.532054 | `eventgrid_topic_list` | ❌ |
| 5 | 0.531993 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 358

**Expected Tool:** `resourcehealth_availability-status_get`  
**Prompt:** Get the availability status for resource <resource_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.556629 | `resourcehealth_availability-status_get` | ✅ **EXPECTED** |
| 2 | 0.538211 | `resourcehealth_availability-status_list` | ❌ |
| 3 | 0.377586 | `quota_usage_check` | ❌ |
| 4 | 0.373112 | `monitor_healthmodels_entity_get` | ❌ |
| 5 | 0.349981 | `datadog_monitoredresources_list` | ❌ |

---

## Test 359

**Expected Tool:** `resourcehealth_availability-status_get`  
**Prompt:** Show me the health status of the storage account <storage_account_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.576591 | `storage_account_get` | ❌ |
| 2 | 0.564128 | `resourcehealth_availability-status_get` | ✅ **EXPECTED** |
| 3 | 0.556167 | `storage_blob_container_get` | ❌ |
| 4 | 0.487207 | `storage_blob_get` | ❌ |
| 5 | 0.466898 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 360

**Expected Tool:** `resourcehealth_availability-status_get`  
**Prompt:** What is the availability status of virtual machine <vm_name> in resource group <resource_group_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.577423 | `resourcehealth_availability-status_list` | ❌ |
| 2 | 0.501568 | `resourcehealth_availability-status_get` | ✅ **EXPECTED** |
| 3 | 0.424939 | `mysql_server_list` | ❌ |
| 4 | 0.411960 | `loadtesting_testresource_list` | ❌ |
| 5 | 0.393396 | `managedlustre_fs_list` | ❌ |

---

## Test 361

**Expected Tool:** `resourcehealth_availability-status_list`  
**Prompt:** List availability status for all resources in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.737164 | `resourcehealth_availability-status_list` | ✅ **EXPECTED** |
| 2 | 0.585501 | `redis_list` | ❌ |
| 3 | 0.549766 | `loadtesting_testresource_list` | ❌ |
| 4 | 0.548549 | `grafana_list` | ❌ |
| 5 | 0.544505 | `subscription_list` | ❌ |

---

## Test 362

**Expected Tool:** `resourcehealth_availability-status_list`  
**Prompt:** Show me the health status of all my Azure resources  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.644984 | `resourcehealth_availability-status_list` | ✅ **EXPECTED** |
| 2 | 0.545208 | `resourcehealth_availability-status_get` | ❌ |
| 3 | 0.509740 | `resourcehealth_health-events_list` | ❌ |
| 4 | 0.508252 | `quota_usage_check` | ❌ |
| 5 | 0.505776 | `redis_list` | ❌ |

---

## Test 363

**Expected Tool:** `resourcehealth_availability-status_list`  
**Prompt:** What resources in resource group <resource_group_name> have health issues?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.596974 | `resourcehealth_availability-status_list` | ✅ **EXPECTED** |
| 2 | 0.549900 | `resourcehealth_availability-status_get` | ❌ |
| 3 | 0.496640 | `resourcehealth_health-events_list` | ❌ |
| 4 | 0.441921 | `applens_resource_diagnose` | ❌ |
| 5 | 0.433522 | `loadtesting_testresource_list` | ❌ |

---

## Test 364

**Expected Tool:** `resourcehealth_health-events_list`  
**Prompt:** List all service health events in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.690720 | `resourcehealth_health-events_list` | ✅ **EXPECTED** |
| 2 | 0.554895 | `search_service_list` | ❌ |
| 3 | 0.534251 | `eventgrid_topic_list` | ❌ |
| 4 | 0.529916 | `eventgrid_subscription_list` | ❌ |
| 5 | 0.518427 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 365

**Expected Tool:** `resourcehealth_health-events_list`  
**Prompt:** Show me Azure service health events for subscription <subscription_id>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.686448 | `resourcehealth_health-events_list` | ✅ **EXPECTED** |
| 2 | 0.534703 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.513815 | `search_service_list` | ❌ |
| 4 | 0.513259 | `eventgrid_topic_list` | ❌ |
| 5 | 0.501135 | `subscription_list` | ❌ |

---

## Test 366

**Expected Tool:** `resourcehealth_health-events_list`  
**Prompt:** What service issues have occurred in the last 30 days?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.450841 | `resourcehealth_health-events_list` | ✅ **EXPECTED** |
| 2 | 0.267663 | `applens_resource_diagnose` | ❌ |
| 3 | 0.246236 | `cloudarchitect_design` | ❌ |
| 4 | 0.216861 | `resourcehealth_availability-status_list` | ❌ |
| 5 | 0.211842 | `search_service_list` | ❌ |

---

## Test 367

**Expected Tool:** `resourcehealth_health-events_list`  
**Prompt:** List active service health events in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.685391 | `resourcehealth_health-events_list` | ✅ **EXPECTED** |
| 2 | 0.528118 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.524063 | `eventgrid_topic_list` | ❌ |
| 4 | 0.520197 | `search_service_list` | ❌ |
| 5 | 0.502110 | `resourcehealth_availability-status_list` | ❌ |

---

## Test 368

**Expected Tool:** `resourcehealth_health-events_list`  
**Prompt:** Show me planned maintenance events for my Azure services  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.565851 | `resourcehealth_health-events_list` | ✅ **EXPECTED** |
| 2 | 0.437868 | `search_service_list` | ❌ |
| 3 | 0.403742 | `eventgrid_subscription_list` | ❌ |
| 4 | 0.402483 | `resourcehealth_availability-status_list` | ❌ |
| 5 | 0.397735 | `quota_usage_check` | ❌ |

---

## Test 369

**Expected Tool:** `servicebus_queue_details`  
**Prompt:** Show me the details of service bus <service_bus_name> queue <queue_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.642876 | `servicebus_queue_details` | ✅ **EXPECTED** |
| 2 | 0.460932 | `servicebus_topic_subscription_details` | ❌ |
| 3 | 0.436980 | `servicebus_topic_details` | ❌ |
| 4 | 0.385812 | `search_knowledge_base_get` | ❌ |
| 5 | 0.384139 | `storage_account_get` | ❌ |

---

## Test 370

**Expected Tool:** `servicebus_topic_details`  
**Prompt:** Show me the details of service bus <service_bus_name> topic <topic_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.642952 | `servicebus_topic_details` | ✅ **EXPECTED** |
| 2 | 0.571860 | `servicebus_topic_subscription_details` | ❌ |
| 3 | 0.483976 | `servicebus_queue_details` | ❌ |
| 4 | 0.482958 | `eventgrid_topic_list` | ❌ |
| 5 | 0.458772 | `eventgrid_subscription_list` | ❌ |

---

## Test 371

**Expected Tool:** `servicebus_topic_subscription_details`  
**Prompt:** Show me the details of service bus <service_bus_name> subscription <subscription_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.633250 | `servicebus_topic_subscription_details` | ✅ **EXPECTED** |
| 2 | 0.517658 | `servicebus_topic_details` | ❌ |
| 3 | 0.494536 | `servicebus_queue_details` | ❌ |
| 4 | 0.493849 | `eventgrid_topic_list` | ❌ |
| 5 | 0.472217 | `eventgrid_subscription_list` | ❌ |

---

## Test 372

**Expected Tool:** `signalr_runtime_get`  
**Prompt:** Show me the details of SignalR <signalr_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.532544 | `signalr_runtime_get` | ✅ **EXPECTED** |
| 2 | 0.355028 | `redis_list` | ❌ |
| 3 | 0.329727 | `foundry_resource_get` | ❌ |
| 4 | 0.319136 | `sql_server_show` | ❌ |
| 5 | 0.304420 | `servicebus_queue_details` | ❌ |

---

## Test 373

**Expected Tool:** `signalr_runtime_get`  
**Prompt:** Show me the network information of SignalR runtime <signalr_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.573446 | `signalr_runtime_get` | ✅ **EXPECTED** |
| 2 | 0.337088 | `sql_server_show` | ❌ |
| 3 | 0.306499 | `foundry_resource_get` | ❌ |
| 4 | 0.305021 | `redis_list` | ❌ |
| 5 | 0.300956 | `servicebus_topic_details` | ❌ |

---

## Test 374

**Expected Tool:** `signalr_runtime_get`  
**Prompt:** Describe the SignalR runtime <signalr_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.710353 | `signalr_runtime_get` | ✅ **EXPECTED** |
| 2 | 0.411319 | `loadtesting_testresource_list` | ❌ |
| 3 | 0.410582 | `foundry_resource_get` | ❌ |
| 4 | 0.399447 | `resourcehealth_availability-status_list` | ❌ |
| 5 | 0.382028 | `sql_server_list` | ❌ |

---

## Test 375

**Expected Tool:** `signalr_runtime_get`  
**Prompt:** Get information about my SignalR runtime <signalr_name> in <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.715974 | `signalr_runtime_get` | ✅ **EXPECTED** |
| 2 | 0.459029 | `foundry_resource_get` | ❌ |
| 3 | 0.430867 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.430682 | `loadtesting_testresource_list` | ❌ |
| 5 | 0.417032 | `functionapp_get` | ❌ |

---

## Test 376

**Expected Tool:** `signalr_runtime_get`  
**Prompt:** Show all the SignalRs information in <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.564094 | `signalr_runtime_get` | ✅ **EXPECTED** |
| 2 | 0.501046 | `redis_list` | ❌ |
| 3 | 0.494522 | `resourcehealth_availability-status_list` | ❌ |
| 4 | 0.481291 | `loadtesting_testresource_list` | ❌ |
| 5 | 0.462031 | `mysql_server_list` | ❌ |

---

## Test 377

**Expected Tool:** `signalr_runtime_get`  
**Prompt:** List all SignalRs in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.530589 | `signalr_runtime_get` | ✅ **EXPECTED** |
| 2 | 0.507661 | `postgres_server_list` | ❌ |
| 3 | 0.495102 | `redis_list` | ❌ |
| 4 | 0.494508 | `kusto_cluster_list` | ❌ |
| 5 | 0.487816 | `subscription_list` | ❌ |

---

## Test 378

**Expected Tool:** `sql_db_create`  
**Prompt:** Create a new SQL database named <database_name> in server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.516780 | `sql_db_create` | ✅ **EXPECTED** |
| 2 | 0.470892 | `sql_server_create` | ❌ |
| 3 | 0.420504 | `sql_db_rename` | ❌ |
| 4 | 0.408515 | `sql_db_delete` | ❌ |
| 5 | 0.404860 | `sql_server_delete` | ❌ |

---

## Test 379

**Expected Tool:** `sql_db_create`  
**Prompt:** Create a SQL database <database_name> with Basic tier in server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.571760 | `sql_db_create` | ✅ **EXPECTED** |
| 2 | 0.459672 | `sql_server_create` | ❌ |
| 3 | 0.437525 | `sql_server_delete` | ❌ |
| 4 | 0.420843 | `sql_db_show` | ❌ |
| 5 | 0.417661 | `sql_db_delete` | ❌ |

---

## Test 380

**Expected Tool:** `sql_db_create`  
**Prompt:** Create a new database called <database_name> on SQL server <server_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.604472 | `sql_db_create` | ✅ **EXPECTED** |
| 2 | 0.545906 | `sql_server_create` | ❌ |
| 3 | 0.504013 | `sql_db_rename` | ❌ |
| 4 | 0.494377 | `sql_db_show` | ❌ |
| 5 | 0.474284 | `sql_db_list` | ❌ |

---

## Test 381

**Expected Tool:** `sql_db_delete`  
**Prompt:** Delete the SQL database <database_name> from server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.568196 | `sql_db_delete` | ✅ **EXPECTED** |
| 2 | 0.567412 | `sql_server_delete` | ❌ |
| 3 | 0.391509 | `sql_db_rename` | ❌ |
| 4 | 0.386564 | `sql_server_firewall-rule_delete` | ❌ |
| 5 | 0.364776 | `sql_db_show` | ❌ |

---

## Test 382

**Expected Tool:** `sql_db_delete`  
**Prompt:** Remove database <database_name> from SQL server <server_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.567513 | `sql_server_delete` | ❌ |
| 2 | 0.543440 | `sql_db_delete` | ✅ **EXPECTED** |
| 3 | 0.500756 | `sql_db_show` | ❌ |
| 4 | 0.481083 | `sql_db_rename` | ❌ |
| 5 | 0.479219 | `sql_db_list` | ❌ |

---

## Test 383

**Expected Tool:** `sql_db_delete`  
**Prompt:** Delete the database called <database_name> on server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.509916 | `sql_db_delete` | ✅ **EXPECTED** |
| 2 | 0.490893 | `sql_server_delete` | ❌ |
| 3 | 0.364493 | `postgres_database_list` | ❌ |
| 4 | 0.355416 | `mysql_database_list` | ❌ |
| 5 | 0.347837 | `sql_db_rename` | ❌ |

---

## Test 384

**Expected Tool:** `sql_db_list`  
**Prompt:** List all databases in the Azure SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.642754 | `sql_db_list` | ✅ **EXPECTED** |
| 2 | 0.639694 | `mysql_database_list` | ❌ |
| 3 | 0.609154 | `postgres_database_list` | ❌ |
| 4 | 0.602889 | `cosmos_database_list` | ❌ |
| 5 | 0.570140 | `kusto_database_list` | ❌ |

---

## Test 385

**Expected Tool:** `sql_db_list`  
**Prompt:** Show me all the databases configuration details in the Azure SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.617531 | `sql_server_show` | ❌ |
| 2 | 0.608733 | `sql_db_list` | ✅ **EXPECTED** |
| 3 | 0.557379 | `mysql_database_list` | ❌ |
| 4 | 0.553497 | `mysql_server_config_get` | ❌ |
| 5 | 0.524316 | `sql_db_show` | ❌ |

---

## Test 386

**Expected Tool:** `sql_db_rename`  
**Prompt:** Rename the SQL database <database_name> on server <server_name> to <new_database_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.593129 | `sql_db_rename` | ✅ **EXPECTED** |
| 2 | 0.425180 | `sql_server_delete` | ❌ |
| 3 | 0.416073 | `sql_db_delete` | ❌ |
| 4 | 0.396792 | `sql_db_create` | ❌ |
| 5 | 0.345708 | `sql_db_show` | ❌ |

---

## Test 387

**Expected Tool:** `sql_db_rename`  
**Prompt:** Rename my Azure SQL database <database_name> to <new_database_name> on server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.713529 | `sql_db_rename` | ✅ **EXPECTED** |
| 2 | 0.516937 | `sql_server_delete` | ❌ |
| 3 | 0.508979 | `sql_db_delete` | ❌ |
| 4 | 0.502821 | `sql_db_create` | ❌ |
| 5 | 0.433347 | `sql_db_show` | ❌ |

---

## Test 388

**Expected Tool:** `sql_db_show`  
**Prompt:** Get the configuration details for the SQL database <database_name> on server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.610865 | `sql_server_show` | ❌ |
| 2 | 0.593107 | `postgres_server_config_get` | ❌ |
| 3 | 0.530342 | `mysql_server_config_get` | ❌ |
| 4 | 0.528195 | `sql_db_show` | ✅ **EXPECTED** |
| 5 | 0.465165 | `sql_db_list` | ❌ |

---

## Test 389

**Expected Tool:** `sql_db_show`  
**Prompt:** Show me the details of SQL database <database_name> in server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.530095 | `sql_db_show` | ✅ **EXPECTED** |
| 2 | 0.502927 | `sql_server_show` | ❌ |
| 3 | 0.439786 | `sql_db_list` | ❌ |
| 4 | 0.438622 | `mysql_table_schema_get` | ❌ |
| 5 | 0.432919 | `mysql_database_list` | ❌ |

---

## Test 390

**Expected Tool:** `sql_db_update`  
**Prompt:** Update the performance tier of SQL database <database_name> on server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.603271 | `sql_db_update` | ✅ **EXPECTED** |
| 2 | 0.467571 | `sql_db_create` | ❌ |
| 3 | 0.440493 | `sql_db_rename` | ❌ |
| 4 | 0.427621 | `sql_db_show` | ❌ |
| 5 | 0.413941 | `sql_server_delete` | ❌ |

---

## Test 391

**Expected Tool:** `sql_db_update`  
**Prompt:** Scale SQL database <database_name> on server <server_name> to use <sku_name> SKU  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.550449 | `sql_db_update` | ✅ **EXPECTED** |
| 2 | 0.418358 | `sql_server_delete` | ❌ |
| 3 | 0.401486 | `sql_db_list` | ❌ |
| 4 | 0.395518 | `sql_db_rename` | ❌ |
| 5 | 0.394770 | `sql_db_show` | ❌ |

---

## Test 392

**Expected Tool:** `sql_elastic-pool_list`  
**Prompt:** List all elastic pools in SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.678124 | `sql_elastic-pool_list` | ✅ **EXPECTED** |
| 2 | 0.502272 | `sql_db_list` | ❌ |
| 3 | 0.498367 | `mysql_database_list` | ❌ |
| 4 | 0.485249 | `aks_nodepool_get` | ❌ |
| 5 | 0.478480 | `sql_server_show` | ❌ |

---

## Test 393

**Expected Tool:** `sql_elastic-pool_list`  
**Prompt:** Show me the elastic pools configured for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.606425 | `sql_elastic-pool_list` | ✅ **EXPECTED** |
| 2 | 0.502138 | `sql_server_show` | ❌ |
| 3 | 0.457103 | `sql_db_list` | ❌ |
| 4 | 0.450743 | `aks_nodepool_get` | ❌ |
| 5 | 0.432816 | `mysql_database_list` | ❌ |

---

## Test 394

**Expected Tool:** `sql_elastic-pool_list`  
**Prompt:** What elastic pools are available in my SQL server <server_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.592709 | `sql_elastic-pool_list` | ✅ **EXPECTED** |
| 2 | 0.420325 | `mysql_database_list` | ❌ |
| 3 | 0.407169 | `aks_nodepool_get` | ❌ |
| 4 | 0.402616 | `mysql_server_list` | ❌ |
| 5 | 0.397782 | `sql_db_list` | ❌ |

---

## Test 395

**Expected Tool:** `sql_server_create`  
**Prompt:** Create a new Azure SQL server named <server_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.682605 | `sql_server_create` | ✅ **EXPECTED** |
| 2 | 0.563707 | `sql_db_create` | ❌ |
| 3 | 0.529198 | `sql_server_list` | ❌ |
| 4 | 0.482112 | `storage_account_create` | ❌ |
| 5 | 0.474207 | `sql_db_rename` | ❌ |

---

## Test 396

**Expected Tool:** `sql_server_create`  
**Prompt:** Create an Azure SQL server with name <server_name> in location <location> with admin user <admin_user>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.618212 | `sql_server_create` | ✅ **EXPECTED** |
| 2 | 0.510127 | `sql_db_create` | ❌ |
| 3 | 0.472066 | `sql_server_show` | ❌ |
| 4 | 0.441059 | `sql_server_delete` | ❌ |
| 5 | 0.400889 | `sql_db_rename` | ❌ |

---

## Test 397

**Expected Tool:** `sql_server_create`  
**Prompt:** Set up a new SQL server called <server_name> in my resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.589818 | `sql_server_create` | ✅ **EXPECTED** |
| 2 | 0.501403 | `sql_db_create` | ❌ |
| 3 | 0.497890 | `sql_server_list` | ❌ |
| 4 | 0.461181 | `sql_db_rename` | ❌ |
| 5 | 0.442934 | `mysql_server_list` | ❌ |

---

## Test 398

**Expected Tool:** `sql_server_delete`  
**Prompt:** Delete the Azure SQL server <server_name> from resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.656593 | `sql_server_delete` | ✅ **EXPECTED** |
| 2 | 0.548064 | `sql_db_delete` | ❌ |
| 3 | 0.518037 | `sql_server_list` | ❌ |
| 4 | 0.495550 | `sql_server_create` | ❌ |
| 5 | 0.483132 | `workbooks_delete` | ❌ |

---

## Test 399

**Expected Tool:** `sql_server_delete`  
**Prompt:** Remove the SQL server <server_name> from my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.615073 | `sql_server_delete` | ✅ **EXPECTED** |
| 2 | 0.393885 | `postgres_server_list` | ❌ |
| 3 | 0.379760 | `sql_db_delete` | ❌ |
| 4 | 0.376653 | `sql_server_show` | ❌ |
| 5 | 0.350103 | `sql_server_list` | ❌ |

---

## Test 400

**Expected Tool:** `sql_server_delete`  
**Prompt:** Delete SQL server <server_name> permanently  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.624310 | `sql_server_delete` | ✅ **EXPECTED** |
| 2 | 0.454892 | `sql_db_delete` | ❌ |
| 3 | 0.362389 | `sql_server_firewall-rule_delete` | ❌ |
| 4 | 0.341604 | `sql_server_show` | ❌ |
| 5 | 0.318758 | `eventhubs_eventhub_delete` | ❌ |

---

## Test 401

**Expected Tool:** `sql_server_entra-admin_list`  
**Prompt:** List Microsoft Entra ID administrators for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.783479 | `sql_server_entra-admin_list` | ✅ **EXPECTED** |
| 2 | 0.456176 | `sql_server_show` | ❌ |
| 3 | 0.434868 | `sql_server_list` | ❌ |
| 4 | 0.401908 | `sql_server_firewall-rule_list` | ❌ |
| 5 | 0.376340 | `sql_db_list` | ❌ |

---

## Test 402

**Expected Tool:** `sql_server_entra-admin_list`  
**Prompt:** Show me the Entra ID administrators configured for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.713306 | `sql_server_entra-admin_list` | ✅ **EXPECTED** |
| 2 | 0.412927 | `sql_server_show` | ❌ |
| 3 | 0.368082 | `sql_server_list` | ❌ |
| 4 | 0.316119 | `sql_db_list` | ❌ |
| 5 | 0.311085 | `postgres_server_list` | ❌ |

---

## Test 403

**Expected Tool:** `sql_server_entra-admin_list`  
**Prompt:** What Microsoft Entra ID administrators are set up for my SQL server <server_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.646436 | `sql_server_entra-admin_list` | ✅ **EXPECTED** |
| 2 | 0.355976 | `sql_server_show` | ❌ |
| 3 | 0.322154 | `sql_server_list` | ❌ |
| 4 | 0.307776 | `sql_server_create` | ❌ |
| 5 | 0.269738 | `sql_server_delete` | ❌ |

---

## Test 404

**Expected Tool:** `sql_server_firewall-rule_create`  
**Prompt:** Create a firewall rule for my Azure SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.635467 | `sql_server_firewall-rule_create` | ✅ **EXPECTED** |
| 2 | 0.532712 | `sql_server_firewall-rule_list` | ❌ |
| 3 | 0.522184 | `sql_server_firewall-rule_delete` | ❌ |
| 4 | 0.448822 | `sql_server_create` | ❌ |
| 5 | 0.440845 | `sql_server_delete` | ❌ |

---

## Test 405

**Expected Tool:** `sql_server_firewall-rule_create`  
**Prompt:** Add a firewall rule to allow access from IP range <start_ip> to <end_ip> for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.670189 | `sql_server_firewall-rule_create` | ✅ **EXPECTED** |
| 2 | 0.533562 | `sql_server_firewall-rule_list` | ❌ |
| 3 | 0.503648 | `sql_server_firewall-rule_delete` | ❌ |
| 4 | 0.316619 | `sql_server_list` | ❌ |
| 5 | 0.302362 | `sql_server_delete` | ❌ |

---

## Test 406

**Expected Tool:** `sql_server_firewall-rule_create`  
**Prompt:** Create a new firewall rule named <rule_name> for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.685062 | `sql_server_firewall-rule_create` | ✅ **EXPECTED** |
| 2 | 0.574384 | `sql_server_firewall-rule_list` | ❌ |
| 3 | 0.539567 | `sql_server_firewall-rule_delete` | ❌ |
| 4 | 0.428908 | `sql_server_create` | ❌ |
| 5 | 0.395180 | `sql_db_create` | ❌ |

---

## Test 407

**Expected Tool:** `sql_server_firewall-rule_delete`  
**Prompt:** Delete a firewall rule from my Azure SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.691421 | `sql_server_firewall-rule_delete` | ✅ **EXPECTED** |
| 2 | 0.584379 | `sql_server_delete` | ❌ |
| 3 | 0.543857 | `sql_server_firewall-rule_list` | ❌ |
| 4 | 0.540333 | `sql_server_firewall-rule_create` | ❌ |
| 5 | 0.498444 | `sql_db_delete` | ❌ |

---

## Test 408

**Expected Tool:** `sql_server_firewall-rule_delete`  
**Prompt:** Remove the firewall rule <rule_name> from SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.670140 | `sql_server_firewall-rule_delete` | ✅ **EXPECTED** |
| 2 | 0.574404 | `sql_server_firewall-rule_list` | ❌ |
| 3 | 0.530470 | `sql_server_firewall-rule_create` | ❌ |
| 4 | 0.488387 | `sql_server_delete` | ❌ |
| 5 | 0.360347 | `sql_db_delete` | ❌ |

---

## Test 409

**Expected Tool:** `sql_server_firewall-rule_delete`  
**Prompt:** Delete firewall rule <rule_name> for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.671211 | `sql_server_firewall-rule_delete` | ✅ **EXPECTED** |
| 2 | 0.601231 | `sql_server_firewall-rule_list` | ❌ |
| 3 | 0.577330 | `sql_server_firewall-rule_create` | ❌ |
| 4 | 0.499272 | `sql_server_delete` | ❌ |
| 5 | 0.378586 | `sql_db_delete` | ❌ |

---

## Test 410

**Expected Tool:** `sql_server_firewall-rule_list`  
**Prompt:** List all firewall rules for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.729372 | `sql_server_firewall-rule_list` | ✅ **EXPECTED** |
| 2 | 0.549667 | `sql_server_firewall-rule_create` | ❌ |
| 3 | 0.513114 | `sql_server_firewall-rule_delete` | ❌ |
| 4 | 0.468904 | `sql_server_show` | ❌ |
| 5 | 0.418817 | `sql_server_list` | ❌ |

---

## Test 411

**Expected Tool:** `sql_server_firewall-rule_list`  
**Prompt:** Show me the firewall rules for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.630731 | `sql_server_firewall-rule_list` | ✅ **EXPECTED** |
| 2 | 0.524126 | `sql_server_firewall-rule_create` | ❌ |
| 3 | 0.476757 | `sql_server_firewall-rule_delete` | ❌ |
| 4 | 0.410488 | `sql_server_show` | ❌ |
| 5 | 0.348100 | `sql_server_list` | ❌ |

---

## Test 412

**Expected Tool:** `sql_server_firewall-rule_list`  
**Prompt:** What firewall rules are configured for my SQL server <server_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.630546 | `sql_server_firewall-rule_list` | ✅ **EXPECTED** |
| 2 | 0.532454 | `sql_server_firewall-rule_create` | ❌ |
| 3 | 0.473501 | `sql_server_firewall-rule_delete` | ❌ |
| 4 | 0.413050 | `sql_server_show` | ❌ |
| 5 | 0.350513 | `sql_server_list` | ❌ |

---

## Test 413

**Expected Tool:** `sql_server_list`  
**Prompt:** List all Azure SQL servers in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.694404 | `sql_server_list` | ✅ **EXPECTED** |
| 2 | 0.596686 | `mysql_server_list` | ❌ |
| 3 | 0.578496 | `sql_db_list` | ❌ |
| 4 | 0.515851 | `sql_elastic-pool_list` | ❌ |
| 5 | 0.509789 | `sql_db_show` | ❌ |

---

## Test 414

**Expected Tool:** `sql_server_list`  
**Prompt:** Show me every SQL server available in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.618218 | `sql_server_list` | ✅ **EXPECTED** |
| 2 | 0.593837 | `mysql_server_list` | ❌ |
| 3 | 0.542819 | `sql_db_list` | ❌ |
| 4 | 0.507486 | `resourcehealth_availability-status_list` | ❌ |
| 5 | 0.496200 | `group_list` | ❌ |

---

## Test 415

**Expected Tool:** `sql_server_show`  
**Prompt:** Show me the details of Azure SQL server <server_name> in resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.629672 | `sql_db_show` | ❌ |
| 2 | 0.594241 | `sql_server_show` | ✅ **EXPECTED** |
| 3 | 0.587728 | `sql_server_list` | ❌ |
| 4 | 0.559893 | `mysql_server_list` | ❌ |
| 5 | 0.540368 | `sql_db_list` | ❌ |

---

## Test 416

**Expected Tool:** `sql_server_show`  
**Prompt:** Get the configuration details for SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.658604 | `sql_server_show` | ✅ **EXPECTED** |
| 2 | 0.610507 | `postgres_server_config_get` | ❌ |
| 3 | 0.538034 | `mysql_server_config_get` | ❌ |
| 4 | 0.471541 | `sql_db_show` | ❌ |
| 5 | 0.445430 | `postgres_server_param_get` | ❌ |

---

## Test 417

**Expected Tool:** `sql_server_show`  
**Prompt:** Display the properties of SQL server <server_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.563019 | `sql_server_show` | ✅ **EXPECTED** |
| 2 | 0.392488 | `postgres_server_config_get` | ❌ |
| 3 | 0.379973 | `postgres_server_param_get` | ❌ |
| 4 | 0.372128 | `sql_server_firewall-rule_list` | ❌ |
| 5 | 0.370547 | `sql_db_show` | ❌ |

---

## Test 418

**Expected Tool:** `storage_account_create`  
**Prompt:** Create a new storage account called testaccount123 in East US region  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.533536 | `storage_account_create` | ✅ **EXPECTED** |
| 2 | 0.438046 | `storage_blob_container_create` | ❌ |
| 3 | 0.418191 | `storage_account_get` | ❌ |
| 4 | 0.414518 | `storage_blob_container_get` | ❌ |
| 5 | 0.373238 | `managedlustre_fs_create` | ❌ |

---

## Test 419

**Expected Tool:** `storage_account_create`  
**Prompt:** Create a storage account with premium performance and LRS replication  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.500621 | `storage_account_create` | ✅ **EXPECTED** |
| 2 | 0.484673 | `managedlustre_fs_create` | ❌ |
| 3 | 0.407222 | `storage_account_get` | ❌ |
| 4 | 0.406804 | `storage_blob_container_create` | ❌ |
| 5 | 0.400151 | `managedlustre_fs_sku_get` | ❌ |

---

## Test 420

**Expected Tool:** `storage_account_create`  
**Prompt:** Create a new storage account with Data Lake Storage Gen2 enabled  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.588979 | `storage_account_create` | ✅ **EXPECTED** |
| 2 | 0.537944 | `managedlustre_fs_create` | ❌ |
| 3 | 0.509732 | `storage_blob_container_create` | ❌ |
| 4 | 0.462526 | `storage_account_get` | ❌ |
| 5 | 0.447060 | `sql_db_create` | ❌ |

---

## Test 421

**Expected Tool:** `storage_account_get`  
**Prompt:** Show me the details for my storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.673750 | `storage_account_get` | ✅ **EXPECTED** |
| 2 | 0.608256 | `storage_blob_container_get` | ❌ |
| 3 | 0.556457 | `storage_blob_get` | ❌ |
| 4 | 0.483379 | `storage_account_create` | ❌ |
| 5 | 0.439236 | `cosmos_account_list` | ❌ |

---

## Test 422

**Expected Tool:** `storage_account_get`  
**Prompt:** Get details about the storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.692687 | `storage_account_get` | ✅ **EXPECTED** |
| 2 | 0.577547 | `storage_blob_container_get` | ❌ |
| 3 | 0.529205 | `storage_blob_get` | ❌ |
| 4 | 0.518165 | `storage_account_create` | ❌ |
| 5 | 0.448506 | `storage_blob_container_create` | ❌ |

---

## Test 423

**Expected Tool:** `storage_account_get`  
**Prompt:** List all storage accounts in my subscription including their location and SKU  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.649215 | `storage_account_get` | ✅ **EXPECTED** |
| 2 | 0.557015 | `managedlustre_fs_sku_get` | ❌ |
| 3 | 0.550148 | `storage_blob_container_get` | ❌ |
| 4 | 0.547647 | `subscription_list` | ❌ |
| 5 | 0.536909 | `cosmos_account_list` | ❌ |

---

## Test 424

**Expected Tool:** `storage_account_get`  
**Prompt:** Show me my storage accounts with whether hierarchical namespace (HNS) is enabled  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.556860 | `storage_account_get` | ✅ **EXPECTED** |
| 2 | 0.482418 | `storage_blob_container_get` | ❌ |
| 3 | 0.461236 | `managedlustre_fs_list` | ❌ |
| 4 | 0.421642 | `cosmos_account_list` | ❌ |
| 5 | 0.410587 | `storage_blob_get` | ❌ |

---

## Test 425

**Expected Tool:** `storage_account_get`  
**Prompt:** Show me the storage accounts in my subscription and include HTTPS-only and public blob access settings  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.619462 | `storage_account_get` | ✅ **EXPECTED** |
| 2 | 0.556436 | `storage_blob_container_get` | ❌ |
| 3 | 0.518229 | `storage_blob_get` | ❌ |
| 4 | 0.473598 | `cosmos_account_list` | ❌ |
| 5 | 0.465571 | `subscription_list` | ❌ |

---

## Test 426

**Expected Tool:** `storage_blob_container_create`  
**Prompt:** Create the storage container mycontainer in storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.649793 | `storage_blob_container_create` | ✅ **EXPECTED** |
| 2 | 0.583896 | `storage_blob_container_get` | ❌ |
| 3 | 0.524786 | `storage_account_create` | ❌ |
| 4 | 0.496679 | `storage_blob_get` | ❌ |
| 5 | 0.447784 | `cosmos_database_container_list` | ❌ |

---

## Test 427

**Expected Tool:** `storage_blob_container_create`  
**Prompt:** Create the container using blob public access in storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.682161 | `storage_blob_container_create` | ✅ **EXPECTED** |
| 2 | 0.590160 | `storage_blob_container_get` | ❌ |
| 3 | 0.559264 | `storage_blob_get` | ❌ |
| 4 | 0.500642 | `storage_account_create` | ❌ |
| 5 | 0.420514 | `storage_account_get` | ❌ |

---

## Test 428

**Expected Tool:** `storage_blob_container_create`  
**Prompt:** Create a new blob container named documents with container public access in storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.625397 | `storage_blob_container_create` | ✅ **EXPECTED** |
| 2 | 0.543503 | `storage_blob_container_get` | ❌ |
| 3 | 0.497804 | `storage_blob_get` | ❌ |
| 4 | 0.463216 | `storage_account_create` | ❌ |
| 5 | 0.435099 | `cosmos_database_container_list` | ❌ |

---

## Test 429

**Expected Tool:** `storage_blob_container_get`  
**Prompt:** Show me the properties of the storage container <container> in the storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.701642 | `storage_blob_container_get` | ✅ **EXPECTED** |
| 2 | 0.623681 | `storage_blob_get` | ❌ |
| 3 | 0.577921 | `storage_account_get` | ❌ |
| 4 | 0.549804 | `storage_blob_container_create` | ❌ |
| 5 | 0.523289 | `cosmos_database_container_list` | ❌ |

---

## Test 430

**Expected Tool:** `storage_blob_container_get`  
**Prompt:** List all blob containers in the storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.712037 | `storage_blob_container_get` | ✅ **EXPECTED** |
| 2 | 0.680802 | `storage_blob_get` | ❌ |
| 3 | 0.613933 | `cosmos_database_container_list` | ❌ |
| 4 | 0.556319 | `storage_blob_container_create` | ❌ |
| 5 | 0.518266 | `storage_account_get` | ❌ |

---

## Test 431

**Expected Tool:** `storage_blob_container_get`  
**Prompt:** Show me the containers in the storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.713527 | `storage_blob_container_get` | ✅ **EXPECTED** |
| 2 | 0.592373 | `cosmos_database_container_list` | ❌ |
| 3 | 0.586169 | `storage_blob_get` | ❌ |
| 4 | 0.523322 | `storage_account_get` | ❌ |
| 5 | 0.487520 | `storage_blob_container_create` | ❌ |

---

## Test 432

**Expected Tool:** `storage_blob_get`  
**Prompt:** Show me the properties for blob <blob> in container <container> in storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.700972 | `storage_blob_get` | ✅ **EXPECTED** |
| 2 | 0.646973 | `storage_blob_container_get` | ❌ |
| 3 | 0.541019 | `storage_blob_container_create` | ❌ |
| 4 | 0.527427 | `storage_account_get` | ❌ |
| 5 | 0.477946 | `cosmos_database_container_list` | ❌ |

---

## Test 433

**Expected Tool:** `storage_blob_get`  
**Prompt:** Get the details about blob <blob> in the container <container> in storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.694997 | `storage_blob_get` | ✅ **EXPECTED** |
| 2 | 0.631161 | `storage_blob_container_get` | ❌ |
| 3 | 0.589151 | `storage_blob_container_create` | ❌ |
| 4 | 0.580226 | `storage_account_get` | ❌ |
| 5 | 0.457005 | `storage_account_create` | ❌ |

---

## Test 434

**Expected Tool:** `storage_blob_get`  
**Prompt:** List all blobs in the blob container <container> in the storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.733586 | `storage_blob_get` | ✅ **EXPECTED** |
| 2 | 0.700891 | `storage_blob_container_get` | ❌ |
| 3 | 0.605993 | `storage_blob_container_create` | ❌ |
| 4 | 0.579070 | `cosmos_database_container_list` | ❌ |
| 5 | 0.506639 | `cosmos_database_container_item_query` | ❌ |

---

## Test 435

**Expected Tool:** `storage_blob_get`  
**Prompt:** Show me the blobs in the blob container <container> in the storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.704426 | `storage_blob_get` | ✅ **EXPECTED** |
| 2 | 0.664940 | `storage_blob_container_get` | ❌ |
| 3 | 0.561557 | `storage_blob_container_create` | ❌ |
| 4 | 0.533515 | `cosmos_database_container_list` | ❌ |
| 5 | 0.484018 | `storage_account_get` | ❌ |

---

## Test 436

**Expected Tool:** `storage_blob_upload`  
**Prompt:** Upload file <local-file-path> to storage blob <blob> in container <container> in storage account <account>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.566181 | `storage_blob_upload` | ✅ **EXPECTED** |
| 2 | 0.525674 | `storage_blob_container_create` | ❌ |
| 3 | 0.517616 | `storage_blob_get` | ❌ |
| 4 | 0.473645 | `storage_blob_container_get` | ❌ |
| 5 | 0.382117 | `storage_account_create` | ❌ |

---

## Test 437

**Expected Tool:** `subscription_list`  
**Prompt:** List all subscriptions for my account  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.654071 | `subscription_list` | ✅ **EXPECTED** |
| 2 | 0.512964 | `cosmos_account_list` | ❌ |
| 3 | 0.471653 | `postgres_server_list` | ❌ |
| 4 | 0.469023 | `kusto_cluster_list` | ❌ |
| 5 | 0.461078 | `redis_list` | ❌ |

---

## Test 438

**Expected Tool:** `subscription_list`  
**Prompt:** Show me my subscriptions  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.458821 | `subscription_list` | ✅ **EXPECTED** |
| 2 | 0.407465 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.393695 | `eventgrid_topic_list` | ❌ |
| 4 | 0.391555 | `redis_list` | ❌ |
| 5 | 0.381238 | `postgres_server_list` | ❌ |

---

## Test 439

**Expected Tool:** `subscription_list`  
**Prompt:** What is my current subscription?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.432335 | `subscription_list` | ✅ **EXPECTED** |
| 2 | 0.320612 | `marketplace_product_list` | ❌ |
| 3 | 0.316899 | `marketplace_product_get` | ❌ |
| 4 | 0.293293 | `eventgrid_subscription_list` | ❌ |
| 5 | 0.289293 | `eventgrid_topic_list` | ❌ |

---

## Test 440

**Expected Tool:** `subscription_list`  
**Prompt:** What subscriptions do I have?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.477591 | `subscription_list` | ✅ **EXPECTED** |
| 2 | 0.357657 | `eventgrid_subscription_list` | ❌ |
| 3 | 0.354286 | `marketplace_product_list` | ❌ |
| 4 | 0.344549 | `redis_list` | ❌ |
| 5 | 0.340836 | `eventgrid_topic_list` | ❌ |

---

## Test 441

**Expected Tool:** `azureterraformbestpractices_get`  
**Prompt:** Fetch the Azure Terraform best practices  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.686886 | `azureterraformbestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.625284 | `deploy_iac_rules_get` | ❌ |
| 3 | 0.605048 | `get_bestpractices_get` | ❌ |
| 4 | 0.546983 | `azureagentbestpractices_get` | ❌ |
| 5 | 0.482936 | `deploy_pipeline_guidance_get` | ❌ |

---

## Test 442

**Expected Tool:** `azureterraformbestpractices_get`  
**Prompt:** Show me the Azure Terraform best practices and generate code sample to get a secret from Azure Key Vault  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.581316 | `azureterraformbestpractices_get` | ✅ **EXPECTED** |
| 2 | 0.512141 | `get_bestpractices_get` | ❌ |
| 3 | 0.509999 | `deploy_iac_rules_get` | ❌ |
| 4 | 0.473597 | `keyvault_secret_get` | ❌ |
| 5 | 0.459792 | `azureagentbestpractices_get` | ❌ |

---

## Test 443

**Expected Tool:** `virtualdesktop_hostpool_list`  
**Prompt:** List all host pools in my subscription  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.711929 | `virtualdesktop_hostpool_list` | ✅ **EXPECTED** |
| 2 | 0.659676 | `virtualdesktop_hostpool_host_list` | ❌ |
| 3 | 0.620665 | `kusto_cluster_list` | ❌ |
| 4 | 0.548888 | `search_service_list` | ❌ |
| 5 | 0.535739 | `virtualdesktop_hostpool_host_user-list` | ❌ |

---

## Test 444

**Expected Tool:** `virtualdesktop_hostpool_host_list`  
**Prompt:** List all session hosts in host pool <hostpool_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.727000 | `virtualdesktop_hostpool_host_list` | ✅ **EXPECTED** |
| 2 | 0.714468 | `virtualdesktop_hostpool_host_user-list` | ❌ |
| 3 | 0.573394 | `virtualdesktop_hostpool_list` | ❌ |
| 4 | 0.438659 | `aks_nodepool_get` | ❌ |
| 5 | 0.393721 | `sql_elastic-pool_list` | ❌ |

---

## Test 445

**Expected Tool:** `virtualdesktop_hostpool_host_user-list`  
**Prompt:** List all user sessions on session host <sessionhost_name> in host pool <hostpool_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.812659 | `virtualdesktop_hostpool_host_user-list` | ✅ **EXPECTED** |
| 2 | 0.659145 | `virtualdesktop_hostpool_host_list` | ❌ |
| 3 | 0.501132 | `virtualdesktop_hostpool_list` | ❌ |
| 4 | 0.357561 | `aks_nodepool_get` | ❌ |
| 5 | 0.336385 | `monitor_workspace_list` | ❌ |

---

## Test 446

**Expected Tool:** `workbooks_create`  
**Prompt:** Create a new workbook named <workbook_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.552212 | `workbooks_create` | ✅ **EXPECTED** |
| 2 | 0.417950 | `workbooks_update` | ❌ |
| 3 | 0.361364 | `workbooks_delete` | ❌ |
| 4 | 0.329118 | `workbooks_show` | ❌ |
| 5 | 0.328113 | `workbooks_list` | ❌ |

---

## Test 447

**Expected Tool:** `workbooks_delete`  
**Prompt:** Delete the workbook with resource ID <workbook_resource_id>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.621310 | `workbooks_delete` | ✅ **EXPECTED** |
| 2 | 0.498518 | `workbooks_show` | ❌ |
| 3 | 0.432454 | `workbooks_create` | ❌ |
| 4 | 0.425569 | `workbooks_list` | ❌ |
| 5 | 0.421897 | `workbooks_update` | ❌ |

---

## Test 448

**Expected Tool:** `workbooks_list`  
**Prompt:** List all workbooks in my resource group <resource_group_name>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.772430 | `workbooks_list` | ✅ **EXPECTED** |
| 2 | 0.562485 | `workbooks_create` | ❌ |
| 3 | 0.516739 | `grafana_list` | ❌ |
| 4 | 0.494073 | `workbooks_show` | ❌ |
| 5 | 0.488599 | `group_list` | ❌ |

---

## Test 449

**Expected Tool:** `workbooks_list`  
**Prompt:** What workbooks do I have in resource group <resource_group_name>?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.708612 | `workbooks_list` | ✅ **EXPECTED** |
| 2 | 0.570260 | `workbooks_create` | ❌ |
| 3 | 0.499716 | `workbooks_show` | ❌ |
| 4 | 0.485504 | `workbooks_delete` | ❌ |
| 5 | 0.472378 | `grafana_list` | ❌ |

---

## Test 450

**Expected Tool:** `workbooks_show`  
**Prompt:** Get information about the workbook with resource ID <workbook_resource_id>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.686087 | `workbooks_show` | ✅ **EXPECTED** |
| 2 | 0.498390 | `workbooks_create` | ❌ |
| 3 | 0.494708 | `workbooks_list` | ❌ |
| 4 | 0.463156 | `workbooks_update` | ❌ |
| 5 | 0.452348 | `workbooks_delete` | ❌ |

---

## Test 451

**Expected Tool:** `workbooks_show`  
**Prompt:** Show me the workbook with resource ID <workbook_resource_id>  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.581501 | `workbooks_show` | ✅ **EXPECTED** |
| 2 | 0.500475 | `workbooks_list` | ❌ |
| 3 | 0.468996 | `workbooks_create` | ❌ |
| 4 | 0.466266 | `workbooks_update` | ❌ |
| 5 | 0.455311 | `workbooks_delete` | ❌ |

---

## Test 452

**Expected Tool:** `workbooks_update`  
**Prompt:** Update the workbook <workbook_resource_id> with a new text step  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.586347 | `workbooks_update` | ✅ **EXPECTED** |
| 2 | 0.382651 | `workbooks_create` | ❌ |
| 3 | 0.349689 | `workbooks_delete` | ❌ |
| 4 | 0.347944 | `workbooks_show` | ❌ |
| 5 | 0.292904 | `loadtesting_testrun_update` | ❌ |

---

## Test 453

**Expected Tool:** `bicepschema_get`  
**Prompt:** How can I use Bicep to create an Azure OpenAI service?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.543154 | `bicepschema_get` | ✅ **EXPECTED** |
| 2 | 0.486006 | `deploy_iac_rules_get` | ❌ |
| 3 | 0.485970 | `foundry_models_deploy` | ❌ |
| 4 | 0.470151 | `azureagentbestpractices_get` | ❌ |
| 5 | 0.453281 | `foundry_openai_embeddings-create` | ❌ |

---

## Test 454

**Expected Tool:** `cloudarchitect_design`  
**Prompt:** Please help me design an architecture for a large-scale file upload, storage, and retrieval service  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.500887 | `cloudarchitect_design` | ✅ **EXPECTED** |
| 2 | 0.290876 | `storage_blob_upload` | ❌ |
| 3 | 0.260647 | `managedlustre_fs_create` | ❌ |
| 4 | 0.254991 | `deploy_architecture_diagram_generate` | ❌ |
| 5 | 0.245034 | `managedlustre_fs_subnetsize_validate` | ❌ |

---

## Test 455

**Expected Tool:** `cloudarchitect_design`  
**Prompt:** Help me design an Azure cloud service that will serve as an ATM for users  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.506943 | `cloudarchitect_design` | ✅ **EXPECTED** |
| 2 | 0.377941 | `deploy_architecture_diagram_generate` | ❌ |
| 3 | 0.341462 | `deploy_pipeline_guidance_get` | ❌ |
| 4 | 0.328747 | `get_bestpractices_get` | ❌ |
| 5 | 0.326226 | `azureagentbestpractices_get` | ❌ |

---

## Test 456

**Expected Tool:** `cloudarchitect_design`  
**Prompt:** I want to design a cloud app for ordering groceries  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.421506 | `cloudarchitect_design` | ✅ **EXPECTED** |
| 2 | 0.271943 | `deploy_pipeline_guidance_get` | ❌ |
| 3 | 0.265972 | `deploy_architecture_diagram_generate` | ❌ |
| 4 | 0.242581 | `deploy_plan_get` | ❌ |
| 5 | 0.229074 | `extension_cli_generate` | ❌ |

---

## Test 457

**Expected Tool:** `cloudarchitect_design`  
**Prompt:** How can I design a cloud service in Azure that will store and present videos for users?  

### Results

| Rank | Score | Tool | Status |
|------|-------|------|--------|
| 1 | 0.533774 | `cloudarchitect_design` | ✅ **EXPECTED** |
| 2 | 0.369969 | `deploy_pipeline_guidance_get` | ❌ |
| 3 | 0.358262 | `managedlustre_fs_create` | ❌ |
| 4 | 0.352797 | `deploy_architecture_diagram_generate` | ❌ |
| 5 | 0.332837 | `azureagentbestpractices_get` | ❌ |

---

## Summary

**Total Prompts Tested:** 457  
**Analysis Execution Time:** 148.4019053s  

### Success Rate Metrics

**Top Choice Success:** 91.9% (420/457 tests)  

#### Confidence Level Distribution

**💪 Very High Confidence (≥0.8):** 3.3% (15/457 tests)  
**🎯 High Confidence (≥0.7):** 23.4% (107/457 tests)  
**✅ Good Confidence (≥0.6):** 62.6% (286/457 tests)  
**👍 Fair Confidence (≥0.5):** 92.3% (422/457 tests)  
**👌 Acceptable Confidence (≥0.4):** 99.6% (455/457 tests)  
**❌ Low Confidence (<0.4):** 0.4% (2/457 tests)  

#### Top Choice + Confidence Combinations

**💪 Top Choice + Very High Confidence (≥0.8):** 3.3% (15/457 tests)  
**🎯 Top Choice + High Confidence (≥0.7):** 23.4% (107/457 tests)  
**✅ Top Choice + Good Confidence (≥0.6):** 60.8% (278/457 tests)  
**👍 Top Choice + Fair Confidence (≥0.5):** 86.9% (397/457 tests)  
**👌 Top Choice + Acceptable Confidence (≥0.4):** 91.9% (420/457 tests)  

### Success Rate Analysis

🟢 **Excellent** - The tool selection system is performing exceptionally well.

⚠️ **Recommendation:** Tool descriptions need improvement to better match user intent (targets: ≥0.6 good, ≥0.7 high).

