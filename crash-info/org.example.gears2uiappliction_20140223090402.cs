S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.0
Build-Number: R720XXE0AOH9
Build-Date: 2015.09.30 10:38:10

Crash Information
Process Name: gears2uiappliction
PID: 3133
Date: 2014-02-23 09:04:02+0900
Executable File Path: /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0x413a7098

Register Information
r0   = 0x00000000, r1   = 0x41422f08
r2   = 0x44673a60, r3   = 0x413a7098
r4   = 0x44609d88, r5   = 0x44673a60
r6   = 0x41428278, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x00000000
r10  = 0x00000000, fp   = 0x4461c948
ip   = 0x40381800, sp   = 0xbeed0348
lr   = 0x40132fc3, pc   = 0x413a7098
cpsr = 0x60000010

Memory Information
MemTotal:   489836 KB
MemFree:     48884 KB
Buffers:     13992 KB
Cached:     170884 KB
VmPeak:      75872 KB
VmSize:      74852 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15444 KB
VmRSS:       15444 KB
VmData:      22256 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       20340 KB
VmPTE:          46 KB
VmSwap:          0 KB

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
41185000 41189000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41199000 4119e000 r-xp /usr/lib/libappcore-common.so.1.1
411a6000 411a8000 r-xp /usr/lib/libiniparser.so.0
411b1000 411b6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
411c2000 411e3000 rw-p [heap]
411e3000 411e7000 r-xp /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction
411f7000 411f9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41202000 41208000 r-xp /usr/lib/libappsvc.so.0.1.0
41211000 41237000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41240000 4130f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
41325000 4132f000 r-xp /lib/libnss_files-2.13.so
415f5000 41600000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41609000 4160c000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
41615000 41621000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4162a000 4164a000 r-xp /usr/lib/libefl-extension.so.0.1.0
41652000 4165e000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
41666000 41678000 r-xp /usr/lib/libefl-assist.so.0.1.0
41681000 41739000 r-xp /usr/lib/libcairo.so.2.11200.14
41744000 41748000 r-xp /usr/lib/libchromium.so.1.0
41750000 41766000 r-xp /usr/lib/libtts.so
4176f000 41792000 r-xp /usr/lib/libui-extension.so.0.1.0
4179b000 417a2000 r-xp /usr/lib/libtbm.so.1.0.0
417aa000 417b8000 r-xp /usr/lib/libGLESv2.so.2.0
417c1000 417c2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
417cb000 417d1000 r-xp /usr/lib/libxcb-render.so.0.0.0
417d9000 417dc000 r-xp /usr/lib/libEGL.so.1.4
417e4000 417e9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
417f1000 4192e000 r-xp /usr/lib/libicui18n.so.51.1
4193e000 41a22000 r-xp /usr/lib/libicuuc.so.51.1
41a37000 41a3b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a43000 41a4b000 r-xp /usr/lib/libdrm.so.2.4.0
42fd9000 42fe0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42fe9000 42ff0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42ff8000 42ffa000 r-xp /usr/lib/libdri2.so.0.0.0
43002000 43023000 r-xp /usr/lib/libexif.so.12.3.3
43036000 4303b000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43043000 4310d000 r-xp /usr/lib/libCOREGL.so.4.0
43450000 4345b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43464000 43468000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43470000 43487000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43594000 43595000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4359d000 4359f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
445a7000 445ac000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
445b4000 445c4000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
beeb0000 beed1000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3133)
Call Stack Count: 1
 0: (0x413a7098) (null)
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
WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.195200
02-23 09:04:00.223+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:00.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:00.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:0.421
02-23 09:04:00.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.195800
02-23 09:04:00.418+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:00.618+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:00.618+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:0.620
02-23 09:04:00.618+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.196000
02-23 09:04:00.618+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:00.818+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:00.818+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:0.822
02-23 09:04:00.818+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.195600
02-23 09:04:00.818+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:01.018+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:01.018+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:1.20
02-23 09:04:01.018+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.196000
02-23 09:04:01.018+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:01.218+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:01.218+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:1.222
02-23 09:04:01.218+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.195600
02-23 09:04:01.218+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:01.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:01.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:1.420
02-23 09:04:01.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.196000
02-23 09:04:01.418+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:01.613+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:01.618+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:1.620
02-23 09:04:01.623+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.196000
02-23 09:04:01.628+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:01.823+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:01.823+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:1.826
02-23 09:04:01.823+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.194800
02-23 09:04:01.823+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:02.018+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:02.018+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:2.23
02-23 09:04:02.018+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.195400
02-23 09:04:02.018+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:02.218+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:02.218+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:2.221
02-23 09:04:02.218+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.195800
02-23 09:04:02.218+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:02.253+0900 D/AUL     ( 3528): launch.c: app_request_to_launchpad(268) > [SECURE_LOG] launch request : org.example.gears2uiappliction
02-23 09:04:02.253+0900 D/AUL     ( 3528): app_sock.c: __app_send_raw(251) > pid(-2) : cmd(0)
02-23 09:04:02.258+0900 W/AUL_AMD (  491): amd_request.c: __request_handler(639) > __request_handler: 0
02-23 09:04:02.258+0900 D/AUL_AMD (  491): amd_request.c: __request_handler(657) > [SECURE_LOG] alias appid: org.example.gears2uiappliction, appid: org.example.gears2uiappliction
02-23 09:04:02.263+0900 D/PKGMGR_INFO(  491): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3737) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:02.263+0900 D/PKGMGR_INFO(  491): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3743) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'ko-kr') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:02.268+0900 I/AUL_AMD (  491): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-23 09:04:02.268+0900 D/AUL_AMD (  491): amd_status.c: _status_get_appid_bypid(520) > second chance
02-23 09:04:02.268+0900 D/AUL_AMD (  491): amd_status.c: _status_get_appid_bypid(525) > second chance pgid = 3526, pid = 3528
02-23 09:04:02.278+0900 D/PKGMGR_INFO(  491): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3737) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:02.278+0900 D/PKGMGR_INFO(  491): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3743) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'ko-kr') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/bin/bash' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:02.283+0900 I/AUL_AMD (  491): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-23 09:04:02.283+0900 E/AUL_AMD (  491): amd_launch.c: _start_app(1648) > no caller appid info, ret: -1
02-23 09:04:02.283+0900 W/AUL_AMD (  491): amd_launch.c: _start_app(1658) > caller pid : 3528
02-23 09:04:02.293+0900 D/AUL_AMD (  491): amd_launch.c: _start_app(1860) > [SECURE_LOG] prelaunch attribute 1000(2) for org.example.gears2uiappliction
02-23 09:04:02.293+0900 D/RESOURCED(  624): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > [proc_dbus_prelaunch_signal_handler,531] call proc_dbus_prelaunch_handler: appid = org.example.gears2uiappliction, pkgid = org.example.gears2uiappliction, flags = 8
02-23 09:04:02.293+0900 D/RESOURCED(  624): appinfo-list.c: resourced_appinfo_get(117) > [resourced_appinfo_get,117] appid org.example.gears2uiappliction, pkgname = org.example.gears2uiappliction, ref = 1
02-23 09:04:02.293+0900 E/RESOURCED(  624): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.gears2uiappliction, table num : 3
02-23 09:04:02.293+0900 E/RESOURCED(  624): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
02-23 09:04:02.293+0900 W/AUL_AMD (  491): amd_launch.c: __send_proc_prelaunch_signal(452) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.gears2uiappliction) pkgid(org.example.gears2uiappliction) attribute(8)
02-23 09:04:02.293+0900 D/AUL_AMD (  491): amd_launch.c: _start_app(2008) > process_pool: false
02-23 09:04:02.293+0900 D/AUL_AMD (  491): amd_launch.c: _start_app(2011) > h/w acceleration: SYS
02-23 09:04:02.293+0900 D/AUL_AMD (  491): amd_launch.c: _start_app(2013) > [SECURE_LOG] appid: org.example.gears2uiappliction
02-23 09:04:02.293+0900 W/AUL_AMD (  491): amd_launch.c: _start_app(2025) > pad pid(-5)
02-23 09:04:02.293+0900 D/AUL_AMD (  491): amd_launch.c: __set_appinfo_for_launchpad(2282) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-23 09:04:02.293+0900 D/AUL     (  491): app_sock.c: __app_send_raw(251) > pid(-5) : cmd(0)
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: main(681) > pfds[LAUNCH_PAD].revent  : 0x1
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: main(684) > pfds[POOL_TYPE + 0].revents : 0x0
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: main(685) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: main(684) > pfds[POOL_TYPE + 1].revents : 0x0
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: main(685) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: main(698) > pfds[LAUNCH_PAD].revents & POLLIN
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: __launchpad_main_loop(469) > [SECURE_LOG] pkg name : org.example.gears2uiappliction
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): process_pool.h: __get_launchpad_type(70) > [launchpad] launchpad type: COMMON(0)
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: __modify_bundle(235) > parsing app_path: No arguments
02-23 09:04:02.298+0900 W/AUL_PAD ( 1077): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
02-23 09:04:02.298+0900 D/AUL     ( 1077): process_pool.c: __send_pkt_raw_data(242) > send(10) : 736 / 736
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: __send_launchpad_loader(419) > [SECURE_LOG] Request to candidate process, pid: 3133, bin path: /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction
02-23 09:04:02.298+0900 W/AUL_PAD ( 1077): launchpad.c: __send_result_to_caller(265) > Check app launching
02-23 09:04:02.298+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_proces_fd_handler(465) > [candidate] ECORE_FD_READ
02-23 09:04:02.298+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_proces_fd_handler(484) > [candidate] recv_ret: 736, pkt->len: 728
02-23 09:04:02.298+0900 D/AUL_PAD ( 1077): launchpad.c: __send_result_to_caller(290) > -- now wait cmdline changing --
02-23 09:04:02.298+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(348) > [SECURE_LOG] app id: org.example.gears2uiappliction, launchpad type: 0
02-23 09:04:02.298+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __modify_bundle(234) > parsing app_path: No arguments
02-23 09:04:02.298+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(369) > [SECURE_LOG] app id: org.example.gears2uiappliction
02-23 09:04:02.298+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(384) > [SECURE_LOG] pkg id: org.example.gears2uiappliction
02-23 09:04:02.298+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(399) > high_priority: false
02-23 09:04:02.298+0900 W/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_prepare_exec(257) > [SECURE_LOG] [candidata] pkg_name : org.example.gears2uiappliction / pkg_type : rpm / app_path : /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction 
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADEzOTMxMTM4NDIvMjU3NzM5AA==##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAzNTI4AA==##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_process_launchpad_main_loop(432) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_proces_fd_handler(488) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction, real app argc: 8
02-23 09:04:02.338+0900 D/AUL_PAD ( 3133): launchpad_loader.c: __candidate_proces_fd_handler(492) > [candidate] ecore main loop quit
02-23 09:04:02.338+0900 I/AUL_PAD ( 3133): launchpad_loader.c: main(691) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction)
02-23 09:04:02.383+0900 I/efl-extension( 3133): efl_extension.c: eext_mod_init(40) > Init
02-23 09:04:02.383+0900 I/UXT     ( 3133): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-23 09:04:02.383+0900 D/AUL     ( 3133): pkginfo.c: aul_app_get_appid_bypid(256) > [SECURE_LOG] appid for 3133 is org.example.gears2uiappliction
02-23 09:04:02.383+0900 I/CAPI_APPFW_APPLICATION( 3133): app_main.c: ui_app_main(704) > app_efl_main
02-23 09:04:02.383+0900 D/LAUNCH  ( 3133): appcore-efl.c: appcore_efl_main(1601) > [gears2uiappliction:Application:main:done]
02-23 09:04:02.383+0900 D/APP_CORE( 3133): appcore-efl.c: appcore_efl_main(1602) > [SECURE_LOG] [gears2uiappliction:Application:Launch]
02-23 09:04:02.383+0900 D/AUL     ( 3133): pkginfo.c: aul_app_get_appid_bypid(256) > [SECURE_LOG] appid for 3133 is org.example.gears2uiappliction
02-23 09:04:02.388+0900 D/APP_CORE( 3133): appcore-efl.c: __before_loop(1043) > elm_config_preferred_engine_set is not called
02-23 09:04:02.388+0900 D/APP_CORE( 3133): appcore-efl.c: __before_loop(1055) > taskmanage is true true
02-23 09:04:02.388+0900 D/APP_CORE( 3133): appcore.c: appcore_init(558) > [SECURE_LOG] locale dir: /opt/usr/apps/org.example.gears2uiappliction/res/locale
02-23 09:04:02.388+0900 D/APP_CORE( 3133): appcore-i18n.c: __load_lang_info_for_fallback_translated_msg(62) > default lang : fr_FR.UTF-8
02-23 09:04:02.388+0900 D/APP_CORE( 3133): appcore-i18n.c: update_region(115) > *****appcore setlocale=ko_KR.UTF-8
02-23 09:04:02.388+0900 D/AUL     ( 3133): app_sock.c: __create_server_sock(122) > pg path - already exists
02-23 09:04:02.388+0900 D/LAUNCH  ( 3133): appcore-efl.c: __before_loop(1062) > [gears2uiappliction:Platform:appcore_init:done]
02-23 09:04:02.388+0900 I/CAPI_APPFW_APPLICATION( 3133): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
02-23 09:04:02.398+0900 D/AUL_PAD ( 1077): launchpad.c: __send_result_to_caller(281) > -- now wait app mainloop creation --
02-23 09:04:02.398+0900 D/AUL     (  491): simple_util.c: __trm_app_info_send_socket(296) > __trm_app_info_send_socket
02-23 09:04:02.398+0900 D/AUL     (  491): simple_util.c: __trm_app_info_send_socket(323) > send
02-23 09:04:02.398+0900 D/AUL     ( 3528): launch.c: app_request_to_launchpad(282) > launch request result : 3133
02-23 09:04:02.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:02.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:2.420
02-23 09:04:02.418+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.196000
02-23 09:04:02.418+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:02.428+0900 D/APP_CORE( 3133): appcore-rotation.c: __dbus_signal_handler_init_with_param(259) > app signal initialized
02-23 09:04:02.428+0900 D/RESOURCED(  624): proc-main.c: resourced_proc_status_change(882) > [SECURE_LOG] [resourced_proc_status_change,882] launch request org.example.gears2uiappliction, 3133
02-23 09:04:02.428+0900 D/RESOURCED(  624): proc-main.c: resourced_proc_status_change(884) > [SECURE_LOG] [resourced_proc_status_change,884] launch request org.example.gears2uiappliction with pkgname
02-23 09:04:02.428+0900 E/RESOURCED(  624): proc-main.c: proc_add_program_list(232) > [proc_add_program_list,232] not found ppi : org.example.gears2uiappliction
02-23 09:04:02.428+0900 D/RESOURCED(  624): proc-main.c: resourced_proc_status_change(894) > [resourced_proc_status_change,894] available memory = 221
02-23 09:04:02.518+0900 E/EFL     ( 3133): ecore_evas<3133> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
02-23 09:04:02.563+0900 I/efl-extension( 3133): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x41415510]'s widget[0x41422608] to elm_conformant widget[0x413a6d98]
02-23 09:04:02.563+0900 I/efl-extension( 3133): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x41415510 = w: 0 h: 0  obj 0x41422608 w: 1 h: 1
02-23 09:04:02.593+0900 I/efl-extension( 3133): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
02-23 09:04:02.593+0900 I/efl-extension( 3133): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
02-23 09:04:02.593+0900 I/efl-extension( 3133): efl_extension_rotary.c: _init_Xi2_system(314) > In
02-23 09:04:02.593+0900 I/efl-extension( 3133): efl_extension_rotary.c: _init_Xi2_system(375) > Done
02-23 09:04:02.593+0900 I/efl-extension( 3133): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x43496a38, elm_image, _activated_obj : 0x0, activated : 1
02-23 09:04:02.613+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:02.613+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:2.618
02-23 09:04:02.613+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.196400
02-23 09:04:02.613+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:02.643+0900 D/IMMODULE( 3133): isf_imf_context.cpp: initialize(3384) > Initializing Ecore ISF IMModule...
02-23 09:04:02.643+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  ppid:1077  trying connect() to local:/tmp/scim-socket-frontend, gears2uiapplict
02-23 09:04:02.648+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  connect() succeeded
02-23 09:04:02.653+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  ppid:1077  trying connect() to local:/tmp/scim-socket-frontend, gears2uiapplict
02-23 09:04:02.653+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  connect() succeeded
02-23 09:04:02.668+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  ppid:1077  trying connect() to local:/tmp/scim-socket-frontend, gears2uiapplict
02-23 09:04:02.673+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  connect() succeeded
02-23 09:04:02.678+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  ppid:1077  trying connect() to local:/tmp/scim-socket-frontend, gears2uiapplict
02-23 09:04:02.683+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  connect() succeeded
02-23 09:04:02.683+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  ppid:1077  trying connect() to local:/tmp/scim-panel-socket:0, gears2uiapplict
02-23 09:04:02.683+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  connect() succeeded
02-23 09:04:02.683+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  ppid:1077  trying connect() to local:/tmp/scim-panel-socket:0, gears2uiapplict
02-23 09:04:02.683+0900 D/ISF_UTILITY( 3133): scim_utility.cpp: isf_save_log(1398) > time:1393113842  pid:3133  scim_socket.cpp  connect  connect() succeeded
02-23 09:04:02.688+0900 D/IMMODULE( 3133): isf_imf_control_ui.cpp: isf_imf_input_panel_init(505) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
02-23 09:04:02.688+0900 D/IMMODULE( 3133): isf_imf_context.cpp: isf_imf_context_add(1231) > create_instance: ab0dcddc-2376-4c5b-83db-360b88490c73
02-23 09:04:02.688+0900 D/IMMODULE( 3133): isf_imf_context.cpp: isf_imf_context_input_hint_set(2269) > ctx : 0x4461cf18, input hint : 0x1
02-23 09:04:02.728+0900 D/ISF_PANEL_EFL(  853): isf_panel_efl.cpp: slot_get_ise_state(5351) > state = 1
02-23 09:04:02.728+0900 D/IMMODULE( 3133): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(916) >     state:1
02-23 09:04:02.748+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.748+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.748+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.748+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.748+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.748+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.753+0900 D/LAUNCH  ( 3133): appcore-efl.c: __before_loop(1072) > [gears2uiappliction:Application:create:done]
02-23 09:04:02.753+0900 E/E17     (  398): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600002)
02-23 09:04:02.758+0900 D/APP_CORE( 3133): appcore-efl.c: __check_wm_rotation_support(709) > Disable window manager rotation
02-23 09:04:02.758+0900 D/APP_CORE( 3133): appcore.c: __aul_handler(448) > [APP 3133]     AUL event: AUL_START
02-23 09:04:02.758+0900 I/APP_CORE( 3133): appcore-efl.c: __do_app(429) > [APP 3133] Event: RESET State: CREATED
02-23 09:04:02.773+0900 D/APP_CORE( 3133): appcore-efl.c: __do_app(461) > [APP 3133] RESET
02-23 09:04:02.773+0900 D/LAUNCH  ( 3133): appcore-efl.c: __do_app(463) > [gears2uiappliction:Application:reset:start]
02-23 09:04:02.773+0900 I/CAPI_APPFW_APPLICATION( 3133): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-23 09:04:02.773+0900 D/APP_SVC ( 3133): appsvc.c: __set_bundle(159) > __set_bundle
02-23 09:04:02.773+0900 I/MESSAGE_PORT( 3133): message_port.cpp: message_port_check_remote_port(189) > [SECURE_LOG] Check remote port (org.example.yjservice):(m_port_uiapp).
02-23 09:04:02.778+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
02-23 09:04:02.788+0900 D/PKGMGR_INFO(  449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3737) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:02.788+0900 D/AUL     ( 3133): pkginfo.c: aul_app_get_appid_bypid(256) > [SECURE_LOG] appid for 3133 is org.example.gears2uiappliction
02-23 09:04:02.788+0900 I/MESSAGE_PORT( 3133): MessagePortProxy.cpp: CheckRemotePort(331) > [SECURE_LOG] Check a remote port : [org.example.yjservice:m_port_uiapp]
02-23 09:04:02.793+0900 D/PKGMGR_INFO(  449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3743) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_changeable_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'ko-kr') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id LEFT OUTER JOIN package_app_changeable_info ON package_app_info.app_id=package_app_changeable_info.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.gears2uiappliction/bin/gears2uiappliction' and package_app_changeable_info.app_disable IN ('false','False')
02-23 09:04:02.808+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
02-23 09:04:02.808+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
02-23 09:04:02.808+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:02.813+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:02.813+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:02.813+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:02.813+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:2.816
02-23 09:04:02.813+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.196800
02-23 09:04:02.813+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:02.818+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-23 09:04:02.818+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-23 09:04:02.818+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:02.818+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[org.example.yjservice:m_port_uiapp]
02-23 09:04:02.818+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [org.example.yjservice:m_port_uiapp]
02-23 09:04:02.818+0900 E/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
02-23 09:04:02.823+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:02.823+0900 E/MESSAGE_PORT( 3133): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (m_port_uiapp) is not found.
02-23 09:04:02.823+0900 D/LAUNCH  ( 3133): appcore-efl.c: __do_app(466) > [gears2uiappliction:Application:reset:done]
02-23 09:04:02.838+0900 W/W_HOME  (  667): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
02-23 09:04:02.843+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 09:04:02.843+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 09:04:02.843+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 09:04:02.843+0900 W/W_HOME  (  667): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
02-23 09:04:02.848+0900 I/GESTURE (  142): gesture.c: BackGestureSetProperty(4475) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-23 09:04:02.858+0900 I/APP_CORE( 3133): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
02-23 09:04:02.858+0900 I/APP_CORE( 3133): appcore-efl.c: __do_app(474) > [APP 3133] Initial Launching, call the resume_cb
02-23 09:04:02.858+0900 I/CAPI_APPFW_APPLICATION( 3133): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
02-23 09:04:02.858+0900 D/APP_CORE( 3133): appcore.c: __aul_handler(451) > [SECURE_LOG] caller_appid : (null)
02-23 09:04:02.858+0900 I/MALI    (  667): egl_platform_x11_tizen.c: tizen_update_native_surface_private(183) > [EGL-X11] surface->[0x442a5d78] swap changed from sync to async
02-23 09:04:02.888+0900 W/APP_CORE( 3133): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
02-23 09:04:02.888+0900 D/APP_CORE( 3133): appcore-efl.c: __add_win(627) > [EVENT_TEST][EVENT] __add_win WIN:4600002
02-23 09:04:02.888+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.888+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.888+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.888+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.888+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.888+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.898+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.898+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.898+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.898+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.898+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.898+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.908+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.908+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.908+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.908+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.908+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.908+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.938+0900 F/EFL     ( 3133): evas_main<3133> main.c:122 evas_debug_magic_wrong() Input object is wrong type
02-23 09:04:02.938+0900 F/EFL     ( 3133):     Expected: 71737723 - Evas_Object
02-23 09:04:02.938+0900 F/EFL     ( 3133):     Supplied: 411e6532 - <UNKNOWN>
02-23 09:04:02.973+0900 D/AUL_AMD (  491): amd_status.c: _status_update_app_info_list(178) > pid(667), status(1)
02-23 09:04:02.988+0900 D/AUL_AMD (  491): amd_launch.c: __e17_status_handler(2165) > pid(3133) status(3)
02-23 09:04:02.988+0900 D/AUL_AMD (  491): amd_key.c: _key_ungrab(250) > _key_ungrab, win : 1200002
02-23 09:04:02.988+0900 W/AUL_AMD (  491): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-23 09:04:02.988+0900 W/AUL_AMD (  491): amd_launch.c: __e17_status_handler(2170) > back key ungrab error
02-23 09:04:02.988+0900 D/AUL_AMD (  491): amd_status.c: _status_update_app_info_list(178) > pid(3133), status(0)
02-23 09:04:02.998+0900 W/W_HOME  (  667): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
02-23 09:04:02.998+0900 W/W_HOME  (  667): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
02-23 09:04:02.998+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 09:04:02.998+0900 W/W_HOME  (  667): event_manager.c: _state_control(333) > appcore paused manually
02-23 09:04:02.998+0900 W/W_HOME  (  667): main.c: home_appcore_pause(717) > Home Appcore Paused
02-23 09:04:02.998+0900 D/W_HOME  (  667): main.c: _pause_cb(665) > Paused
02-23 09:04:02.998+0900 W/W_HOME  (  667): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
02-23 09:04:02.998+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 09:04:03.003+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 09:04:03.003+0900 D/W_HOME  (  667): main.c: home_pause(748) > Home Paused
02-23 09:04:03.003+0900 W/W_HOME  (  667): main.c: home_pause(751) > clock/widget paused
02-23 09:04:03.003+0900 D/W_HOME  (  667): clock_view.c: clock_view_event_handler(560) > event:10002 received
02-23 09:04:03.003+0900 W/W_HOME  (  667): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 09:04:03.003+0900 D/W_HOME  (  667): page.c: page_access_highlight(814) > focus set to 0x46dcba20
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  667): message_port.cpp: message_port_check_remote_port(189) > [SECURE_LOG] Check remote port (com.samsung.w-music-player.music-control-service):(music-control-service-request-message-port).
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  667): MessagePortProxy.cpp: CheckRemotePort(331) > [SECURE_LOG] Check a remote port : [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  667): message_port.cpp: message_port_send_message(211) > [SECURE_LOG] Send a message to the remote port (com.samsung.w-music-player.music-control-service):(music-control-service-request-message-port).
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  667): MessagePortProxy.cpp: SendMessage(403) > [SECURE_LOG] Send a message to : [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(395) > [SECURE_LOG] _MessagePortService::GetKey Key:[com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-23 09:04:03.003+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-23 09:04:03.003+0900 D/W_HOME  (  667): clock_shortcut.c: _mp_messageport_register(153) > requested a music state via message port
02-23 09:04:03.003+0900 W/W_HOME  (  667): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
02-23 09:04:03.003+0900 D/APP_CORE(  667): appcore-efl.c: __update_win(673) > [EVENT_TEST][EVENT] __update_win WIN:2400003 fully_obscured 1
02-23 09:04:03.003+0900 D/APP_CORE(  667): appcore-efl.c: __visibility_cb(846) > bvisibility 0, b_active 1
02-23 09:04:03.003+0900 D/APP_CORE(  667): appcore-efl.c: __visibility_cb(861) >  Go to Pasue state 
02-23 09:04:03.003+0900 I/APP_CORE(  667): appcore-efl.c: __do_app(429) > [APP 667] Event: PAUSE State: RUNNING
02-23 09:04:03.003+0900 D/APP_CORE(  667): appcore-efl.c: __do_app(503) > [APP 667] PAUSE
02-23 09:04:03.003+0900 I/CAPI_APPFW_APPLICATION(  667): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-23 09:04:03.003+0900 W/W_HOME  (  667): main.c: _appcore_pause_cb(690) > appcore pause
02-23 09:04:03.003+0900 D/W_HOME  (  667): main.c: _pause_cb(665) > Paused
02-23 09:04:03.003+0900 E/W_HOME  (  667): main.c: _pause_cb(668) > paused already
02-23 09:04:03.003+0900 D/APP_CORE(  667): appcore-efl.c: __trm_app_info_send_socket(233) > __trm_app_info_send_socket
02-23 09:04:03.003+0900 D/APP_CORE(  667): appcore-efl.c: __trm_app_info_send_socket(260) > send
02-23 09:04:03.008+0900 D/APP_CORE(  667): appcore-efl.c: _capture_and_make_file(1569) > [SECURE_LOG] Capture : win[2400003] -> redirected win[600058] for com.samsung.w-home[667]
02-23 09:04:03.008+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(917) > state: 2
02-23 09:04:03.013+0900 D/WATCH_CORE(  701): appcore-watch.c: __get_timeinfo(779) > Current time: 2-23 9:4:3.13
02-23 09:04:03.013+0900 D/WATCH_CORE(  701): appcore-watch.c: __watch_core_time_tick(931) > next time tick: 0.197400
02-23 09:04:03.013+0900 I/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_time_tick(305) > _watch_core_time_tick
02-23 09:04:03.013+0900 D/RESOURCED(  624): proc-main.c: resourced_proc_status_change(849) > [SECURE_LOG] [resourced_proc_status_change,849] set foreground : 3133
02-23 09:04:03.013+0900 D/RESOURCED(  624): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1687) > [lowmem_move_memcgroup,1687] pid: 3133, proc_name: org.example.gears2uiappliction, cg_name: foreground, oom_score_adj: 200
02-23 09:04:03.013+0900 D/RESOURCED(  624): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] [cgroup_write_node,133] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3133
02-23 09:04:03.013+0900 I/MESSAGE_PORT(  981): MessagePortProxy.cpp: OnSendMessageInternal(723) > [SECURE_LOG] Message received! from App: com.samsung.w-home, to App: com.samsung.w-music-player.music-control-service, Port: music-control-service-request-message-port, Trusted: FALSE
02-23 09:04:03.013+0900 I/MESSAGE_PORT(  981): message_port.cpp: message_dispatcher(52) > [SECURE_LOG] A message has been received to specific local port id (1) from remote port (com.samsung.w-home):((null)).
02-23 09:04:03.013+0900 D/APP_SVC (  981): appsvc.c: __set_bundle(159) > __set_bundle
02-23 09:04:03.013+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_bundle_foreach_cb(550) > [32m[TID:981]   key:msgId, val:music-messageport-req[0m
02-23 09:04:03.013+0900 D/APP_SVC (  981): appsvc.c: __set_bundle(159) > __set_bundle
02-23 09:04:03.013+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_bundle_foreach_cb(550) > [32m[TID:981]   key:value, val:false[0m
02-23 09:04:03.013+0900 E/CAPI_APPFW_APP_CONTROL(  981): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-23 09:04:03.013+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(255) > [32m[TID:981]   msg port[0m
02-23 09:04:03.013+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(259) > [SECURE_LOG] [T:981] caller = com.samsung.w-home
02-23 09:04:03.013+0900 W/MUSIC_CONTROL_SERVICE(  981): music-control-service.c: _music_control_service_pasre_request(405) > [33m[TID:981]   value = [false][0m
02-23 09:04:03.023+0900 I/MUSIC_CONTROL_SERVICE(  981): music-control-client-manager.c: music_control_client_mgr_remove_client_app(319) > [SECURE_LOG] [T:981] [com.samsung.w-home] removed
02-23 09:04:03.023+0900 D/MUSIC_CONTROL_SERVICE(  981): music-control-client-manager.c: music_control_client_mgr_remove_client_app(321) > [32m[TID:981]   client count = 0[0m
02-23 09:04:03.063+0900 D/RESOURCED(  624): heart-cpu.c: heart_cpu_foreground_state(201) > [heart_cpu_foreground_state,201] heart_cpu_foreground_state : pid = 3133, appname = org.example.gears2uiappliction, pkgname = org.example.gears2uiappliction
02-23 09:04:03.063+0900 D/RESOURCED(  624): cpu.c: cpu_foreground_state(248) > [cpu_foreground_state,248] cpu_foreground_state : pid = 3133, appname = org.example.gears2uiappliction
02-23 09:04:03.063+0900 D/RESOURCED(  624): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] [cgroup_write_node,133] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3133
02-23 09:04:03.063+0900 D/RESOURCED(  624): freezer-process.c: freezer_process_pid_set(156) > [freezer_process_pid_set,156] freezer_process_pid_set 3133
02-23 09:04:03.078+0900 I/wnotib  (  667): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(609) > fully_obscured: 1
02-23 09:04:03.078+0900 E/wnotib  (  667): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4030) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
02-23 09:04:03.083+0900 D/DATA_PROVIDER_MASTER(  661): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 667 is paused
02-23 09:04:03.083+0900 D/DATA_PROVIDER_MASTER(  661): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-23 09:04:03.088+0900 D/DATA_PROVIDER_SLAVE(  725): widget.c: pending_timer_freeze(136) > [SECURE_LOG] Freezed Count: 0
02-23 09:04:03.088+0900 W/WATCH_CORE(  701): appcore-watch.c: __widget_pause(998) > widget_pause
02-23 09:04:03.088+0900 D/WATCH_CORE(  701): appcore-watch.c: __do_app(315) > WE_PAUSE
02-23 09:04:03.088+0900 W/CAPI_WATCH_APPLICATION(  701): watch_app_main.c: _watch_core_pause(252) > [SECURE_LOG] _watch_core_pause, watch: com.samsung.w-watch-chrono
02-23 09:04:03.088+0900 D/WATCH_CHRONO(  701): watch-chrono-main.cpp: _app_pause(441) > >>> ENTER [_app_pause]
02-23 09:04:03.088+0900 D/WATCH_CHRONO(  701): watch-chrono-type-normal.cpp: InitializedSweepSceond(1069) > Stop and Clear mSweepAnimation !!
02-23 09:04:03.093+0900 D/RESOURCED(  624): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1687) > [lowmem_move_memcgroup,1687] pid: 701, proc_name: com.samsung.w-watch-chrono, cg_name: previous, oom_score_adj: 230
02-23 09:04:03.093+0900 D/RESOURCED(  624): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] [cgroup_write_node,133] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 701
02-23 09:04:03.293+0900 W/CRASH_MANAGER( 3531): worker.c: worker_job(1199) > 1103133676561139311384
