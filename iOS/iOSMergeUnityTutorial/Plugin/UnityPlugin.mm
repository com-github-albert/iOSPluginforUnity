//
//  UnityPlugin.m
//  Unity-iPhone
//
//  Created by JT Ma on 16/8/5.
//
//

#import "UnityPlugin.h"

#import "UnityAppController.h"

static BOOL isRunningMainController = false;

extern "C" {
    /**
     *  隐藏界面
     */
    void DismissUnityAnimated() {
        if (GetAppController() != nil && GetAppController().window != nil) {
            [GetAppController().rootViewController dismissViewControllerAnimated:YES completion:nil];
        }
    }
    
    /**
     *  显示主界面
     */
    void PresentUnityAnimated() {
        if (isRunningMainController) {
            return;
        }
        
        UIStoryboard* storyboard = [UIStoryboard storyboardWithName:@"Main" bundle:[NSBundle mainBundle]];
        UISplitViewController *splitViewController = [storyboard instantiateViewControllerWithIdentifier:@"SplitViewController"];
        UINavigationController *navigationController = [splitViewController.viewControllers lastObject];
        
        if (GetAppController() != nil && GetAppController().window != nil) {
            GetAppController().window.rootViewController = navigationController;
            isRunningMainController = true;
        }
    }
}

@implementation UnityPlugin

+ (void)loadLevelWithName:(NSString *)name {
    UnitySendMessage("LoadLevelController",
                     "LoadLevelWithName",
                     name.UTF8String);
}

@end
