# Summary of Problems Faced

- I used an Apple Silicon Mac to build the console application, so I could not use `System.Drawing.Common` locally to decode JPEGs into bitmaps. I considered `SixLabors.ImageSharp`, but the community license application I looked at asked me to provide information. I chose `SkiaSharp` because it works on macOS and Windows and is licensed under MIT.
- Given that the assignment required a Windows console application, I assumed the reviewer would run it on a Windows machine. I do not own a Windows machine, so I decided to use a GitHub-hosted Windows runner rather than set up a virtual machine. I used the runner to build the executable and test it on Windows.
