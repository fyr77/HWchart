
install:
	mkdir /usr/share/hwchart
	cp ${srcdir}/HWchart/HWchart/bin/Release/*.exe /usr/share/hwchart/
	cp ${srcdir}/HWchart/HWchart/bin/Release/*.dll /usr/share/hwchart/
	cp ${srcdir}/HWchart/linux/hwchart.png /usr/share/hwchart/
	cp ${srcdir}/HWchart/linux/hwchart.desktop /usr/share/applications/
	chmod 755 /usr/share/applications/hwchart.desktop
