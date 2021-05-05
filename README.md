# Chromium on macOS Print Crash Repro

This site is a bare bones reproduction of a Chromium crash on macOS. It consists of:
* The default page, which has a single "Print" button. When clicked, it submits a `form` via POST to the "Print" page in a new tab.
* The "Print" page has one function: to call `window.print()` as soon as the document finishes loading.


## Steps to Reproduce

### Via the Proof of Concept Website

I currently have a demo site where you can reproduce the issue without downloading any code:

https://chromiumprintcrashrepro.azurewebsites.net/

Then follow the `Common Steps` below.


### Via Static Files

The Proof of Concept Website costs money, so after this issue is resolved, I will delete it. To preserve this repro, I have included static html files in the `static_files` subdirectory that you can download and open in Chromium to reproduce the issue.


### Common Steps

1. On macOS, either visit [the repro website](https://chromiumprintcrashrepro.azurewebsites.net/) or clone this repository and open `static_files/chromiumrepro.html` in your Chromium-based browser.
1. Click the Print button. The Print page will open in a new tab.
1. The Print page will automatically open the Print dialog. Expand "More Settings" and click "Print using system dialog...". The Print dialog will display.
1. Click the Cancel button.
1. Both the original index page and the Print page will crash and display "Error code: 6".


## Test Machines

The crash only happens on macOS. I also tested it on Windows 10.

* macOS Big Sur 11.3.1
    * Chrome 90.0.4430.93 (Official Build) (x86_64): **crashed**
    * Microsoft Edge 90.0.818.51 (Official build) (64-bit): **crashed**
    * Firefox 88.0 (64-bit): no crash
    * Safari 14.1 (16611.1.21.161.6): no crash
* Windows 10 Version 20H2 (OS Build 19042.928)
    * Chrome 90.0.4430.93 (Official Build) (64-bit): no crash
    * Microsoft Edge 90.0.818.51 (Official build) (64-bit): no crash
    * Firefox 88.0 (64-bit): no crash
