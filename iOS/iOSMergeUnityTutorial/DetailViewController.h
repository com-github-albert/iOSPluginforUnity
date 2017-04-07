//
//  DetailViewController.h
//   
//
//  Created by JT Ma on 21/03/2017.
//  Copyright © 2017 JT Ma. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface DetailViewController : UIViewController

@property (strong, nonatomic) NSDate *detailItem;
@property (weak, nonatomic) IBOutlet UILabel *detailDescriptionLabel;

@end

