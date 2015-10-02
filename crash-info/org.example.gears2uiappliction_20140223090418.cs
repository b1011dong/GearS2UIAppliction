S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.0
Build-Number: R720XXE0AOH9
Build-Date: 2015.09.30 10:38:10

Crash Information
Process Name: gears2uiappliction
PID: 3576
Date: 2014-02-23 09:04:18+0900
Executable File Path: /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0x41214cb8

Register Information
r0   = 0x00000000, r1   = 0x4347b240
r2   = 0x4353e200, r3   = 0x41214cb8
r4   = 0x43494530, r5   = 0x4353e200
r6   = 0x43481928, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x00000000
r10  = 0x00000000, fp   = 0x434eba40
ip   = 0x40381800, sp   = 0xbe945348
lr   = 0x40132fc3, pc   = 0x41214cb8
cpsr = 0x60000010

Memory Information
MemTotal:   489836 KB
MemFree:     29768 KB
Buffers:     13848 KB
Cached:     187072 KB
VmPeak:      74692 KB
VmSize:      73672 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15312 KB
VmRSS:       15312 KB
VmData:      21076 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       20340 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3576 TID = 3576
3576 3596 3598 

Maps Information
40000000 40006000 r-xp /usr/bin/launchpad-loader
4000e000 4002b000 r-xp /lib/ld-2.13.so
40034000 40038000 r-xp /usr/lib/libsys-assert.so
40042000 40048000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40062000 r-xp /usr/lib/libaul.so.0.1.0
4006c000 4006e000 r-xp /lib/libdl-2.13.so
40077000 4007a000 r-xp /usr/lib/libbundle.so.0.1.22
40082000 40084000 r-xp /usr/lib/libdlog.so.0.0.0
4008c000 400a0000 r-xp /lib/libpthread-2.13.so
400ab000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fb000 402ca000 r-xp /usr/lib/libevas.so.1.7.99
402ee000 40305000 r-xp /usr/lib/libecore.so.1.7.99
4031c000 40379000 r-xp /usr/lib/libedje.so.1.7.99
40383000 40453000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40454000 4045e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40466000 40469000 r-xp /usr/lib/libsmack.so.1.0.0
40471000 40479000 r-xp /lib/libgcc_s-4.6.so.1
4047a000 40595000 r-xp /lib/libc-2.13.so
405a3000 405df000 r-xp /usr/lib/libsystemd.so.0.4.0
405e8000 405f3000 r-xp /lib/libunwind.so.8.0.1
40620000 40637000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063f000 40669000 r-xp /usr/lib/libdbus-1.so.3.8.12
40672000 40677000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067f000 406a1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406aa000 406ad000 r-xp /usr/lib/libproc-stat.so.0.2.86
406b5000 406bb000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c4000 4072d000 r-xp /lib/libm-2.13.so
40736000 4074f000 r-xp /usr/lib/libeet.so.1.7.99
40760000 407a1000 r-xp /usr/lib/libeina.so.1.7.99
407aa000 407cc000 r-xp /usr/lib/libecore_evas.so.1.7.99
407d5000 407da000 r-xp /usr/lib/libecore_file.so.1.7.99
407e2000 407f3000 r-xp /usr/lib/libecore_input.so.1.7.99
407fb000 40804000 r-xp /usr/lib/libvconf.so.0.2.45
4080c000 4085c000 r-xp /usr/lib/libecore_x.so.1.7.99
4085e000 40867000 r-xp /usr/lib/libedbus.so.1.7.99
4086f000 40886000 r-xp /usr/lib/libecore_con.so.1.7.99
4088f000 408a2000 r-xp /usr/lib/libfribidi.so.0.3.1
408aa000 408e7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408f0000 40918000 r-xp /usr/lib/libfontconfig.so.1.8.0
40919000 4096f000 r-xp /usr/lib/libfreetype.so.6.11.3
4097b000 409d1000 r-xp /usr/lib/libpixman-1.so.0.28.2
409de000 409e4000 r-xp /lib/librt-2.13.so
409ed000 409f4000 r-xp /usr/lib/libembryo.so.1.7.99
409fc000 40a13000 r-xp /usr/lib/liblua-5.1.so
40a1c000 40a22000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a2a000 40a2b000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a33000 40a59000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40b09000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b15000 40b25000 r-xp /lib/libresolv-2.13.so
40b29000 40bfc000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c07000 40c3b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c44000 40c5e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c66000 40cdb000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ce5000 40cfb000 r-xp /lib/libz.so.1.2.5
40d03000 40d26000 r-xp /usr/lib/libjpeg.so.8.0.2
40d3e000 40e1f000 r-xp /usr/lib/libX11.so.6.3.0
40e2a000 40e2f000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e38000 40e3c000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e45000 40e48000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e50000 40e57000 r-xp /usr/lib/libXcursor.so.1.0.2
40e5f000 40e61000 r-xp /usr/lib/libXdamage.so.1.1.0
40e69000 40e6b000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e73000 40e75000 r-xp /usr/lib/libXgesture.so.7.0.0
40e7d000 40e80000 r-xp /usr/lib/libXfixes.so.3.1.0
40e88000 40e91000 r-xp /usr/lib/libXi.so.6.1.0
40e99000 40e9a000 r-xp /usr/lib/libXinerama.so.1.0.0
40ea3000 40ea9000 r-xp /usr/lib/libXrandr.so.2.2.0
40eb1000 40eb7000 r-xp /usr/lib/libXrender.so.1.3.0
40ebf000 40ec2000 r-xp /usr/lib/libXtst.so.6.1.0
40ecb000 40ed5000 r-xp /usr/lib/libXext.so.6.4.0
40ede000 40ef4000 r-xp /lib/libexpat.so.1.5.2
40efe000 40f16000 r-xp /usr/lib/libpng12.so.0.50.0
40f1e000 40f3b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f43000 40fd7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fea000 40fed000 r-xp /lib/libattr.so.1.1.0
40ff6000 41001000 r-xp /usr/lib/libgpg-error.so.0.15.0
41009000 4100a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41012000 41017000 r-xp /usr/lib/libffi.so.5.0.10
4101f000 41021000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41029000 410f5000 r-xp /usr/lib/libxml2.so.2.7.8
41103000 41106000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
4110e000 41110000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41118000 4112b000 r-xp /usr/lib/libxcb.so.1.1.0
41134000 41136000 r-xp /usr/lib/libiri.so
4113f000 41146000 r-xp /lib/libcrypt-2.13.so
41176000 41178000 r-xp /usr/lib/libXau.so.6.0.0
41285000 41289000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41299000 4129e000 r-xp /usr/lib/libappcore-common.so.1.1
412a6000 412a8000 r-xp /usr/lib/libiniparser.so.0
412b1000 412b5000 r-xp /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction
412c5000 412ca000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
412d2000 412d4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
412dd000 412e3000 r-xp /usr/lib/libappsvc.so.0.1.0
412ec000 41312000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4131b000 413ea000 r-xp /usr/lib/libscim-1.0.so.8.2.3
41400000 4140a000 r-xp /lib/libnss_files-2.13.so
415d0000 415db000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
415e4000 415e7000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
415f0000 415fc000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41605000 41625000 r-xp /usr/lib/libefl-extension.so.0.1.0
4162d000 41639000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
41641000 41653000 r-xp /usr/lib/libefl-assist.so.0.1.0
4165c000 41714000 r-xp /usr/lib/libcairo.so.2.11200.14
4171f000 41723000 r-xp /usr/lib/libchromium.so.1.0
4172b000 41741000 r-xp /usr/lib/libtts.so
4174a000 4176d000 r-xp /usr/lib/libui-extension.so.0.1.0
41776000 4177d000 r-xp /usr/lib/libtbm.so.1.0.0
41785000 41793000 r-xp /usr/lib/libGLESv2.so.2.0
4179c000 4179d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
417a6000 417ac000 r-xp /usr/lib/libxcb-render.so.0.0.0
417b4000 417b7000 r-xp /usr/lib/libEGL.so.1.4
417bf000 417c4000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
417cc000 41909000 r-xp /usr/lib/libicui18n.so.51.1
41919000 419fd000 r-xp /usr/lib/libicuuc.so.51.1
41a12000 41a16000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a1e000 41a26000 r-xp /usr/lib/libdrm.so.2.4.0
42fb4000 42fbb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42fc4000 42fcb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42fd3000 42fd5000 r-xp /usr/lib/libdri2.so.0.0.0
42fdd000 42ffe000 r-xp /usr/lib/libexif.so.12.3.3
43011000 43016000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4301e000 430e8000 r-xp /usr/lib/libCOREGL.so.4.0
4342b000 43436000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4343f000 43443000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4344b000 43462000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4356f000 43570000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43578000 4357a000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43583000 43d82000 rwxp [stack:3596]
43d83000 44582000 rwxp [stack:3598]
44582000 44587000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
4458f000 4459f000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
be925000 be946000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3576)
Call Stack Count: 1
 0: (0x41214cb8) (null)
End of Call Stack

Package Information
Package Name: org.example.gears2uiappliction
Package ID : org.example.gears2uiappliction
Version: 1.0.0
Package Type: rpm
App Name: Money Watcher
App ID: org.example.gears2uiappliction
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:18.363+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: OnSendMessageInternal(723) > [SECURE_LOG] Message received! from App: com.samsung.w-home, to App: com.samsung.w-music-player.music-control-service, Port: music-control-service-request-message-port, Trusted: FALSE
02-23 09:04:18.363+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_dispatcher(52) > [SECURE_LOG] A message has been received to specific local port id (1) from remote port (com.samsung.w-home):((null)).
02-23 09:04:18.363+0900 D/APP_SVC (  981): appsvc.c: __set_bundle(159) > __set_bundle
02-23 09:04:18.363+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_bundle_foreach_cb(550) > [32m[TID:981]   key:msgId, val:music-messageport-req[0m
02-23 09:04:18.363+0900 D/APP_SVC (  981): appsvc.c: __set_bundle(159) > __set_bundle
02-23 09:04:18.363+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_bundle_foreach_cb(550) > [32m[TID:981]   key:value, val:false[0m
02-23 09:04:18.363+0900 E/CAPI_APPFW_APP_CONTROL(  981): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-23 09:04:18.363+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(255) > [32m[TID:981]   msg port[0m
02-23 09:04:18.363+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(259) > [SECURE_LOG] [T:981] caller = com.samsung.w-home
02-23 09:04:18.363+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(405) > [33m[TID:981]   value = [false][0m
02-23 09:04:18.368+0900 D/W_HOME  (  667): clock_shortcut.c: _mp_messageport_register(153) > requested a music state via message port
02-23 09:04:18.368+0900 D/APP_CORE(  667): appcore-efl.c: __trm_app_info_send_socket(233) > __trm_app_info_send_socket
02-23 09:04:18.368+0900 D/APP_CORE(  667): appcore-efl.c: __trm_app_info_send_socket(260) > send
02-23 09:04:18.368+0900 I/GESTURE (  142): gesture.c: BackGestureSetProperty(4507) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
02-23 09:04:18.368+0900 I/GESTURE (  142): gesture.c: BackGestureSetProperty(4507) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
02-23 09:04:18.373+0900 D/APP_CORE(  667): appcore-efl.c: _capture_and_make_file(1569) > [SECURE_LOG] Capture : win[2400003] -> redirected win[600058] for com.samsung.w-home[667]
02-23 09:04:18.373+0900 D/RESOURCED(  624): proc-main.c: resourced_proc_status_change(849) > [SECURE_LOG] [resourced_proc_status_change,849] set foreground : 3576
02-23 09:04:18.373+0900 D/RESOURCED(  624): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1687) > [lowmem_move_memcgroup,1687] pid: 3576, proc_name: org.example.gears2uiappliction, cg_name: foreground, oom_score_adj: 200
02-23 09:04:18.373+0900 D/RESOURCED(  624): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] [cgroup_write_node,133] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3576
02-23 09:04:18.418+0900 D/RESOURCED(  624): heart-cpu.c: heart_cpu_foreground_state(201) > [heart_cpu_foreground_state,201] heart_cpu_foreground_state : pid = 3576, appname = org.example.gears2uiappliction, pkgname = org.example.gears2uiappliction
02-23 09:04:18.423+0900 D/RESOURCED(  624): cpu.c: cpu_foreground_state(248) > [cpu_foreground_state,248] cpu_foreground_state : pid = 3576, appname = org.example.gears2uiappliction
02-23 09:04:18.423+0900 D/RESOURCED(  624): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] [cgroup_write_node,133] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3576
02-23 09:04:18.423+0900 D/RESOURCED(  624): freezer-process.c: freezer_process_pid_set(156) > [freezer_process_pid_set,156] freezer_process_pid_set 3576
02-23 09:04:18.498+0900 I/MUSIC_CONTROL_SERVICE(  981): music-control-client-manager.c: music_control_client_mgr_remove_client_app(319) > [SECURE_LOG] [T:981] [com.samsung.w-home] removed
02-23 09:04:18.498+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-client-manager.c: music_control_client_mgr_remove_client_app(321) > [32m[TID:981]   client count = 0[0m
02-23 09:04:18.548+0900 I/wnotib  (  667): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(609) > fully_obscured: 1
02-23 09:04:18.548+0900 E/wnotib  (  667): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4030) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
02-23 09:04:18.733+0900 D/AUL_AMD (  491): amd_launch.c: __send_cpu_boost(466) > __send_cpu_boost enter
02-23 09:04:18.733+0900 D/AUL_AMD (  491): amd_launch.c: __send_cpu_boost(491) > __send_cpu_boost ok
02-23 09:04:18.733+0900 D/LAUNCH  (  491): amd_launch.c: __e17_status_handler(2190) > [gears2uiappliction:Application:Launching:done]
02-23 09:04:18.868+0900 I/APP_CORE(  667): appcore-efl.c: __do_app(429) > [APP 667] Event: MEM_FLUSH State: PAUSED
02-23 09:04:18.898+0900 D/AUL_PAD ( 1077): launchpad.c: __send_launchpad_loader(435) > Prepare another candidate process
02-23 09:04:18.898+0900 D/AUL_PAD ( 1077): sigchild.h: __signal_block_sigchld(246) > SIGCHLD blocked
02-23 09:04:18.898+0900 D/AUL_PAD ( 1077): sigchild.h: __signal_unblock_sigchld(258) > SIGCHLD unblocked
02-23 09:04:18.918+0900 D/PKGMGR_INFO(  964): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3737) > [SECURE_LOG] where = package_app_info.app_exec='' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:18.918+0900 D/PKGMGR_INFO(  964): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3743) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'ko-kr') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:18.923+0900 I/AUL     (  964): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
02-23 09:04:18.928+0900 D/AUL     (  964): pkginfo.c: __get_id_bypid(216) > second chance
02-23 09:04:18.938+0900 D/PKGMGR_INFO(  964): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3737) > [SECURE_LOG] where = package_app_info.app_exec='' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:18.938+0900 D/PKGMGR_INFO(  964): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3743) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'ko-kr') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:18.943+0900 I/AUL     (  964): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
02-23 09:04:18.943+0900 D/AUL     (  964): pkginfo.c: __get_id_bypid(235) > [SECURE_LOG] no appinfo in pkg db, pid: 3576, cmdline: 
02-23 09:04:18.943+0900 E/CAPI_APPFW_APP_MANAGER(  964): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
02-23 09:04:18.978+0900 D/AUL_AMD (  491): amd_status.c: __app_terminate_timer_cb(162) > pid(3582)
02-23 09:04:18.978+0900 W/AUL_AMD (  491): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
02-23 09:04:19.113+0900 D/AUL_AMD (  491): amd_launch.c: __e17_status_handler(2165) > pid(667) status(3)
02-23 09:04:19.113+0900 D/AUL_AMD (  491): amd_key.c: _key_ungrab(250) > _key_ungrab, win : 1200002
02-23 09:04:19.113+0900 W/AUL_AMD (  491): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-23 09:04:19.113+0900 W/AUL_AMD (  491): amd_launch.c: __e17_status_handler(2170) > back key ungrab error
02-23 09:04:19.113+0900 D/AUL_AMD (  491): amd_status.c: _status_update_app_info_list(178) > pid(667), status(0)
02-23 09:04:19.123+0900 D/RESOURCED(  624): proc-main.c: resourced_proc_status_change(849) > [SECURE_LOG] [resourced_proc_status_change,849] set foreground : 667
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:19.123+0900 E/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
02-23 09:04:19.123+0900 E/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(3576) are closed. delete client info
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
02-23 09:04:19.123+0900 E/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  3576
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.123+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
02-23 09:04:19.128+0900 I/MALI    (  667): egl_platform_x11_tizen.c: tizen_update_native_surface_private(183) > [EGL-X11] surface->[0x442a5d78] swap changed from sync to async
02-23 09:04:19.148+0900 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3576
02-23 09:04:19.148+0900 D/AUL_AMD (  491): amd_key.c: _unregister_key_event(170) > ===key stack===
02-23 09:04:19.148+0900 D/AUL_AMD (  491): amd_status.c: _status_publish_app_status(713) > [SECURE_LOG] pid(3576) status(0)
02-23 09:04:19.148+0900 D/AUL_AMD (  491): amd_status.c: _status_publish_app_status(720) > [SECURE_LOG] pid(3576) appid(org.example.gears2uiappliction)
02-23 09:04:19.148+0900 D/AUL_AMD (  491): amd_status.c: _status_publish_app_status(740) > [SECURE_LOG] appid(com.samsung.svoice)
02-23 09:04:19.148+0900 D/AUL_AMD (  491): amd_status.c: _status_remove_app_info_list(254) > ~STATUS_SERVICE : appid(org.example.gears2uiappliction)
02-23 09:04:19.148+0900 D/AUL_AMD (  491): amd_status.c: _status_remove_app_info_list(267) > pkg : appid(org.example.gears2uiappliction)
02-23 09:04:19.148+0900 D/AUL     (  491): simple_util.c: __trm_app_info_send_socket(296) > __trm_app_info_send_socket
02-23 09:04:19.148+0900 D/AUL     (  491): simple_util.c: __trm_app_info_send_socket(323) > send
02-23 09:04:19.153+0900 D/STARTER (  659): starter.c: _w_app_dead_cb(211) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.35/src/starter.c:211:D] app dead cb call! (pid : 3576)
02-23 09:04:19.153+0900 D/RESOURCED(  624): proc-monitor.c: proc_dbus_aul_terminated(1076) > [proc_dbus_aul_terminated,1076] received terminated process : pid 3576
02-23 09:04:19.153+0900 D/RESOURCED(  624): appinfo-list.c: resourced_appinfo_put(132) > [resourced_appinfo_put,132] appid org.example.gears2uiappliction, pkgname = org.example.gears2uiappliction, ref = 0
02-23 09:04:19.208+0900 D/W_HOME  (  667): main.c: _dead_cb(623) > PID(3576) is dead
02-23 09:04:19.213+0900 W/PROCESSMGR(  398): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
02-23 09:04:19.213+0900 W/WATCH_CORE(  701): appcore-watch.c: __signal_process_manager_handler(1144) > process_manager_signal
02-23 09:04:19.213+0900 I/WATCH_CORE(  701): appcore-watch.c: __signal_process_manager_handler(1160) > Call the time_tick_cb
02-23 09:04:19.218+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:19.219
02-23 09:04:19.218+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:19.263+0900 W/W_HOME  (  667): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
02-23 09:04:19.263+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-23 09:04:19.268+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-23 09:04:19.273+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-23 09:04:19.278+0900 W/W_HOME  (  667): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
02-23 09:04:19.283+0900 W/W_HOME  (  667): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
02-23 09:04:19.283+0900 W/W_HOME  (  667): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
02-23 09:04:19.283+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-23 09:04:19.283+0900 W/W_HOME  (  667): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
02-23 09:04:19.283+0900 D/APP_CORE(  667): appcore-efl.c: __update_win(673) > [EVENT_TEST][EVENT] __update_win WIN:2400003 fully_obscured 0
02-23 09:04:19.283+0900 D/APP_CORE(  667): appcore-efl.c: __visibility_cb(846) > bvisibility 1, b_active 0
02-23 09:04:19.288+0900 D/APP_CORE(  667): appcore-efl.c: __visibility_cb(849) >  Go to Resume state
02-23 09:04:19.288+0900 I/APP_CORE(  667): appcore-efl.c: __do_app(429) > [APP 667] Event: RESUME State: PAUSED
02-23 09:04:19.288+0900 D/LAUNCH  (  667): appcore-efl.c: __do_app(519) > [w-home:Application:resume:start]
02-23 09:04:19.288+0900 D/APP_CORE(  667): appcore-efl.c: __do_app(521) > [APP 667] RESUME
02-23 09:04:19.288+0900 I/CAPI_APPFW_APPLICATION(  667): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-23 09:04:19.288+0900 W/W_HOME  (  667): main.c: _appcore_resume_cb(681) > appcore resume
02-23 09:04:19.288+0900 D/W_HOME  (  667): main.c: _resume_cb(643) > Resumed
02-23 09:04:19.288+0900 W/W_HOME  (  667): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
02-23 09:04:19.293+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-23 09:04:19.293+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-23 09:04:19.293+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-23 09:04:19.293+0900 D/APPS    (  667): apps_main.c: apps_main_resume(583) >  Resume starts
02-23 09:04:19.293+0900 W/APPS    (  667): apps_main.c: _time_changed_cb(293) >  date : 23->23
02-23 09:04:19.293+0900 D/APPS    (  667): layout.c: _resume_result_cb(195) >  
02-23 09:04:19.293+0900 D/APPS    (  667): AppsViewManager.cpp: apps_view_mgr_resume(84) >  
02-23 09:04:19.293+0900 D/APPS    (  667): AppsViewNecklace.cpp: onResume(616) >  
02-23 09:04:19.293+0900 W/W_HOME  (  667): rotary.c: rotary_attach(138) > rotary_attach:0x451e63d0
02-23 09:04:19.293+0900 D/APPS    (  667): AppsViewNecklace.cpp: onRotaryResumeResultCb(4246) >  Activate the rotary events for apps
02-23 09:04:19.293+0900 I/efl-extension(  667): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x451e63d0, elm_layout, _activated_obj : 0x45c7be20, activated : 1
02-23 09:04:19.293+0900 I/efl-extension(  667): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-23 09:04:19.298+0900 D/W_HOME  (  667): event_manager.c: _set_back_win_gesture(166) > disable back gesture
02-23 09:04:19.298+0900 D/W_HOME  (  667): event_manager.c: _set_back_win_gesture(166) > disable back gesture
02-23 09:04:19.303+0900 D/W_HOME  (  667): clock_inf_dbox.c: home_resumed_cb(386) > Thaw all freezed objects
02-23 09:04:19.308+0900 D/LAUNCH  (  667): appcore-efl.c: __do_app(529) > [w-home:Application:resume:done]
02-23 09:04:19.308+0900 D/APP_CORE(  667): appcore-efl.c: __trm_app_info_send_socket(233) > __trm_app_info_send_socket
02-23 09:04:19.308+0900 D/APP_CORE(  667): appcore-efl.c: __trm_app_info_send_socket(260) > send
02-23 09:04:19.308+0900 I/wnotib  (  667): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(609) > fully_obscured: 0
02-23 09:04:19.308+0900 E/wnotib  (  667): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4030) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
02-23 09:04:19.308+0900 W/wnotib  (  667): w-notification-board-noti-manager.c: wnotib_noti_manager_notiboard_vi_rest_time_cb(1596) > No postponed update.
02-23 09:04:19.308+0900 I/GESTURE (  142): gesture.c: BackGestureSetProperty(4507) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
02-23 09:04:19.308+0900 I/GESTURE (  142): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
02-23 09:04:19.308+0900 I/GESTURE (  142): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
02-23 09:04:19.308+0900 I/GESTURE (  142): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
02-23 09:04:19.313+0900 D/WIDGET_EVAS(  667): widget_viewer_evas.c: append_widget_dirty_object_list(3646) > [SECURE_LOG] Box[com.samsung.w-watch-chrono] is not visible
02-23 09:04:19.398+0900 D/AUL_AMD (  491): amd_request.c: __add_history_handler(270) > [SECURE_LOG] appid: org.example.gears2uiappliction, alias_appid: org.example.gears2uiappliction
02-23 09:04:19.398+0900 D/AUL_AMD (  491): amd_request.c: __add_history_handler(292) > [SECURE_LOG] add rua history org.example.gears2uiappliction /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction
02-23 09:04:19.398+0900 D/RUA     (  491): rua.c: rua_add_history(179) > rua_add_history start
02-23 09:04:19.443+0900 D/RUA     (  491): rua.c: rua_add_history(247) > rua_add_history ok
02-23 09:04:19.703+0900 I/MALI    (  667): egl_platform_x11_tizen.c: tizen_update_native_surface_private(174) > [EGL-X11] surface->[0x442a5d78] swap changed from async to sync
02-23 09:04:19.738+0900 D/AUL_PAD ( 3600): launchpad_loader.c: main(551) > [candidate] Another candidate process was forked.
02-23 09:04:19.738+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(52) > max_cmdline_size = 1053
02-23 09:04:19.748+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : 41186778
02-23 09:04:19.753+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(69) > get pre-initialization function
02-23 09:04:19.753+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(73) > get shutdown function
02-23 09:04:19.753+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : 41186a50
02-23 09:04:19.763+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : 411875d8
02-23 09:04:19.768+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(69) > get pre-initialization function
02-23 09:04:19.768+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(73) > get shutdown function
02-23 09:04:19.843+0900 D/AUL_PAD ( 3600): preload.h: __preload_init(65) > preload /usr/lib/ecore/immodules/libisf-imf-module.so# - handle : 411886a0
02-23 09:04:19.848+0900 D/AUL_PAD ( 3600): preexec.h: __preexec_init(76) > preexec start
02-23 09:04:19.848+0900 D/AUL     ( 3600): process_pool.c: __connect_to_launchpad(116) > [launchpad] enter, type: 0
02-23 09:04:19.848+0900 D/AUL     ( 3600): process_pool.c: __connect_to_launchpad(129) > connect to /tmp/.launchpad-type0
02-23 09:04:19.848+0900 D/AUL_PAD ( 1077): launchpad.c: main(681) > pfds[LAUNCH_PAD].revent  : 0x0
02-23 09:04:19.848+0900 D/AUL_PAD ( 1077): launchpad.c: main(684) > pfds[POOL_TYPE + 0].revents : 0x1
02-23 09:04:19.848+0900 D/AUL_PAD ( 1077): launchpad.c: main(685) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-23 09:04:19.848+0900 D/AUL_PAD ( 1077): launchpad.c: main(684) > pfds[POOL_TYPE + 1].revents : 0x0
02-23 09:04:19.848+0900 D/AUL_PAD ( 1077): launchpad.c: main(685) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-23 09:04:19.848+0900 D/AUL_PAD ( 1077): launchpad.c: main(711) > pfds[POOL_TYPE + 0].revents & POLLIN
02-23 09:04:19.848+0900 D/AUL_PAD ( 1077): launchpad.c: main(724) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3600
02-23 09:04:19.848+0900 D/AUL     ( 3600): process_pool.c: __connect_to_launchpad(144) > send(3600) : 4
02-23 09:04:19.848+0900 D/AUL     ( 3600): process_pool.c: __connect_to_launchpad(152) > [SECURE_LOG] [launchpad] done, connect fd: 9
02-23 09:04:20.013+0900 I/AUL_PAD ( 3600): launchpad_loader.c: main(600) > [candidate] elm init, returned: 1
02-23 09:04:20.118+0900 D/AUL_PAD ( 3600): launchpad_loader.c: main(662) > theme path: /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
02-23 09:04:20.118+0900 D/AUL_PAD ( 3600): launchpad_loader.c: main(679) > [candidate] ecore handler add
02-23 09:04:20.118+0900 D/AUL_PAD ( 3600): launchpad_loader.c: main(688) > [candidate] ecore main loop begin
02-23 09:04:20.308+0900 D/W_HOME  (  667): clock_shortcut.c: _reg_delay_timer_cb(397) > 
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  667): message_port.cpp: message_port_check_remote_port(189) > [SECURE_LOG] Check remote port (com.samsung.w-music-player.music-control-service):(music-control-service-request-message-port).
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  667): MessagePortProxy.cpp: CheckRemotePort(331) > [SECURE_LOG] Check a remote port : [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  667): message_port.cpp: message_port_send_message(211) > [SECURE_LOG] Send a message to the remote port (com.samsung.w-music-player.music-control-service):(music-control-service-request-message-port).
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  667): MessagePortProxy.cpp: SendMessage(403) > [SECURE_LOG] Send a message to : [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: OnSendMessageInternal(723) > [SECURE_LOG] Message received! from App: com.samsung.w-home, to App: com.samsung.w-music-player.music-control-service, Port: music-control-service-request-message-port, Trusted: FALSE
02-23 09:04:20.308+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_dispatcher(52) > [SECURE_LOG] A message has been received to specific local port id (1) from remote port (com.samsung.w-home):((null)).
02-23 09:04:20.308+0900 D/APP_SVC (  981): appsvc.c: __set_bundle(159) > __set_bundle
02-23 09:04:20.308+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_bundle_foreach_cb(550) > [32m[TID:981]   key:msgId, val:music-messageport-req[0m
02-23 09:04:20.308+0900 D/APP_SVC (  981): appsvc.c: __set_bundle(159) > __set_bundle
02-23 09:04:20.308+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_bundle_foreach_cb(550) > [32m[TID:981]   key:value, val:true[0m
02-23 09:04:20.308+0900 E/CAPI_APPFW_APP_CONTROL(  981): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-23 09:04:20.308+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(255) > [32m[TID:981]   msg port[0m
02-23 09:04:20.308+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(259) > [SECURE_LOG] [T:981] caller = com.samsung.w-home
02-23 09:04:20.308+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(405) > [33m[TID:981]   value = [true][0m
02-23 09:04:20.308+0900 D/AUL     (  981): app_sock.c: __app_send_raw(251) > pid(-2) : cmd(14)
02-23 09:04:20.313+0900 D/W_HOME  (  667): clock_shortcut.c: _mp_messageport_register(153) > requested a music state via message port
02-23 09:04:20.338+0900 W/AUL_AMD (  491): amd_request.c: __request_handler(639) > __request_handler: 14
02-23 09:04:20.343+0900 D/AUL_AMD (  491): amd_request.c: __request_handler(855) > [SECURE_LOG] APP_IS_RUNNING : com.samsung.w-home : 667
02-23 09:04:20.343+0900 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 667
02-23 09:04:20.358+0900 I/MUSIC_CONTROL_SERVICE(  981): music-control-client-manager.c: music_control_client_mgr_add_client_app(279) > [SECURE_LOG] [T:981] [com.samsung.w-home] added
02-23 09:04:20.358+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-client-manager.c: music_control_client_mgr_add_client_app(281) > [32m[TID:981]   client count = 1[0m
02-23 09:04:20.358+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:981]   [MUSIC_PLAYER_EVENT][0m
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_port_check_remote_port(189) > [SECURE_LOG] Check remote port (com.samsung.w-home):(music-control-service-message-port).
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: CheckRemotePort(331) > [SECURE_LOG] Check a remote port : [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.363+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_port_send_message(211) > [SECURE_LOG] Send a message to the remote port (com.samsung.w-home):(music-control-service-message-port).
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: SendMessage(403) > [SECURE_LOG] Send a message to : [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  667): MessagePortProxy.cpp: OnSendMessageInternal(723) > [SECURE_LOG] Message received! from App: com.samsung.w-music-player.music-control-service, to App: com.samsung.w-home, Port: music-control-service-message-port, Trusted: FALSE
02-23 09:04:20.368+0900 I/MESSAGE_PORT(  667): message_port.cpp: message_dispatcher(52) > [SECURE_LOG] A message has been received to specific local port id (1) from remote port (com.samsung.w-music-player.music-control-service):((null)).
02-23 09:04:20.368+0900 D/W_HOME  (  667): clock_shortcut.c: _music_service_messageport_cb(345) > msg_id:music-mediachanged-ind remote app id:com.samsung.w-music-player.music-control-service
02-23 09:04:20.368+0900 W/W_HOME  (  667): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-23 09:04:20.368+0900 E/W_HOME  (  667): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-23 09:04:20.368+0900 I/MUSIC_CONTROL_SERVICE(  981): music-control-message.c: music_control_message_send(173) > [SECURE_LOG] [T:981] message(music-mediachanged-ind) is sended to [com.samsung.w-home]
02-23 09:04:20.368+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:981]   [MUSIC_PLAYER_EVENT][0m
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_port_check_remote_port(189) > [SECURE_LOG] Check remote port (com.samsung.w-home):(music-control-service-message-port).
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: CheckRemotePort(331) > [SECURE_LOG] Check a remote port : [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.373+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_port_send_message(211) > [SECURE_LOG] Send a message to the remote port (com.samsung.w-home):(music-control-service-message-port).
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: SendMessage(403) > [SECURE_LOG] Send a message to : [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  667): MessagePortProxy.cpp: OnSendMessageInternal(723) > [SECURE_LOG] Message received! from App: com.samsung.w-music-player.music-control-service, to App: com.samsung.w-home, Port: music-control-service-message-port, Trusted: FALSE
02-23 09:04:20.378+0900 I/MESSAGE_PORT(  667): message_port.cpp: message_dispatcher(52) > [SECURE_LOG] A message has been received to specific local port id (1) from remote port (com.samsung.w-music-player.music-control-service):((null)).
02-23 09:04:20.378+0900 D/W_HOME  (  667): clock_shortcut.c: _music_service_messageport_cb(345) > msg_id:music-playstatechanged-ind remote app id:com.samsung.w-music-player.music-control-service
02-23 09:04:20.378+0900 W/W_HOME  (  667): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-23 09:04:20.378+0900 E/W_HOME  (  667): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-23 09:04:20.378+0900 I/MUSIC_CONTROL_SERVICE(  981): music-control-message.c: music_control_message_send(173) > [SECURE_LOG] [T:981] message(music-playstatechanged-ind) is sended to [com.samsung.w-home]
02-23 09:04:20.383+0900 I/TIZEN_N_SOUND_MANAGER(  981): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
02-23 09:04:20.383+0900 E/TIZEN_N_SOUND_MANAGER(  981): sound_manager_private.c: __convert_sound_manager_error_code(98) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
02-23 09:04:20.383+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:981]   sound_manager_get_volume() .. [0xfe6a0001][0m
02-23 09:04:20.383+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-message.c: music_control_message_send_volume_changed_ind(279) > [32m[TID:981]   volume: 0, earjack: 0[0m
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_port_check_remote_port(189) > [SECURE_LOG] Check remote port (com.samsung.w-home):(music-control-service-message-port).
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: CheckRemotePort(331) > [SECURE_LOG] Check a remote port : [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_port_send_message(211) > [SECURE_LOG] Send a message to the remote port (com.samsung.w-home):(music-control-service-message-port).
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: SendMessage(403) > [SECURE_LOG] Send a message to : [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-23 09:04:20.383+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:20.388+0900 I/MESSAGE_PORT(  667): MessagePortProxy.cpp: OnSendMessageInternal(723) > [SECURE_LOG] Message received! from App: com.samsung.w-music-player.music-control-service, to App: com.samsung.w-home, Port: music-control-service-message-port, Trusted: FALSE
02-23 09:04:20.388+0900 I/MESSAGE_PORT(  667): message_port.cpp: message_dispatcher(52) > [SECURE_LOG] A message has been received to specific local port id (1) from remote port (com.samsung.w-music-player.music-control-service):((null)).
02-23 09:04:20.388+0900 D/W_HOME  (  667): clock_shortcut.c: _music_service_messageport_cb(345) > msg_id:music-volumechanged-ind remote app id:com.samsung.w-music-player.music-control-service
02-23 09:04:20.388+0900 I/MUSIC_CONTROL_SERVICE(  981): music-control-message.c: music_control_message_send(173) > [SECURE_LOG] [T:981] message(music-volumechanged-ind) is sended to [com.samsung.w-home]
02-23 09:04:20.608+0900 D/RESOURCED(  624): heart-abnormal.c: heart_abnormal_process_crashed(81) > [heart_abnormal_process_crashed,81] info : gears2uiappliction /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction 0 
02-23 09:04:20.633+0900 D/PKGMGR_INFO( 1074): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3737) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:20.638+0900 D/PKGMGR_INFO( 1074): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3743) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'ko-kr') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:20.648+0900 I/samsung-log-manager( 1074): SLogMgr_NativeDbHelper.cpp: ExecQuery(180) > [SECURE_LOG] [(180)]: query tmp [INSERT INTO report_app_error_survey(app_id,type,timestamp,time_zone) VALUES ('org.example.gears2uiappliction',1,1393113860650,'Asia/Seoul');]
02-23 09:04:20.648+0900 I/samsung-log-manager( 1074): SLogMgr_NativeDbHelper.cpp: ExecQuery(186) > [SECURE_LOG] [(186)]: sqlite3_exec failed. Query [INSERT INTO report_app_error_survey(app_id,type,timestamp,time_zone) VALUES ('org.example.gears2uiappliction',1,1393113860650,'Asia/Seoul');] Error [8 : attempt to write a readonly database] Extended Error 8
02-23 09:04:20.648+0900 E/samsung-log-manager( 1074): SLogMgr_BaseLogProvider.cpp: Insert(153) > [SECURE_LOG]  [(153)]: Insert query execution failed
02-23 09:04:20.653+0900 W/CRASH_MANAGER( 3531): worker.c: worker_job(1199) > 1103576676561139311385
