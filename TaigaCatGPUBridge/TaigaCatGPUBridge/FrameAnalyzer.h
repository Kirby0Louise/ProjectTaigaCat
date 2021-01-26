//FrameAnalyzer.h - Contains declarations of frame analysis functions

#pragma once

#ifdef FRAMEANALYZER_EXPORTS
#define FRAMEANALYZER_API __declspec(dllexport)
#else
#define FRAMEANALYZER_API __declspec(dllimport)
#endif // 


/*

	Does GPU-accelerated comparison of current frame and previous frame and returns a floating point score indicating how many points this frame should earn in the framerate analysis

	Scoring is dictated as follows -

	Duplicate frame -	 0.0 points
	New frame -			 1.0 points
	Tearing -			 0.X points*

	*where X is (1 - (perecent from the top of the screen the tear is))

	NOTE - Tearing detection currently not implemented, currently only returns either 0 or 1 points

*/
extern "C" FRAMEANALYZER_API float getFrameScore();



/*

	Uploads a framebuffer to the GPU's VRAM, first copying framebuffer A/C/E to B/D/F, then overwriting framebuffer A/C/E with the argument framebuffer
	The feedID argument dictates which of the three dual framebuffers are being modified

	0 - A/B
	1 - C/D
	2 - E/F

*/
extern "C" FRAMEANALYZER_API void uploadNewFrame(int framebuffer[], int feedID);

